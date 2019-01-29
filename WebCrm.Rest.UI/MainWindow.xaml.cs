using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Threading;
using WebCrm.Rest.Model;
using WebCrm.Rest.Net;

namespace WebCrm.Rest.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Api api;
        private IEnumerable<PersonDto> persons;
        private IEnumerable<OrganisationDto> organisations;
        private IEnumerable<OrganisationDto> dupes;
        private IEnumerable<RelationDto> relations;
        private string previousFilter = null;
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();

            api = new Api();
            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(500)
            };
            timer.Tick += new EventHandler(OnFilterUpdated);
        }

        private void LoginClicked(object sender, RoutedEventArgs e)
        {
            json.Document.Blocks.Clear();
            try
            {
                api.Client.UpdateLogin();
                json.Document.Blocks.Add(new Paragraph(new Run("ApiLogin")));
                json.Document.Blocks.Add(new Paragraph(new Run(api.Client.ApiLogin.ToString())));
            }
            catch (Exception ex)
            {
                HandleEx(ex);
            }
        }

        private void BaseObjectDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            try
            {
                if (sender == organisationDtoDataGrid)
                {
                    if (organisationDtoDataGrid.SelectedItem is OrganisationDto org)
                    {
                        if (this.FindResource("selectedOrganisationDtoViewSource") is CollectionViewSource view)
                        {
                            view.Source = new[] { org };
                        }
                        Print(new[] { org });
                    }
                }
                else if (sender == dupeOrganisationDtoDataGrid)
                {
                    if (dupeOrganisationDtoDataGrid.SelectedItem is OrganisationDto org)
                    {
                        if (this.FindResource("selectedOrganisationDtoViewSource") is CollectionViewSource view)
                        {
                            view.Source = new[] { org };
                        }
                        Print(new[] { org });
                    }
                }
                else if (sender == personDtoDataGrid)
                {
                    if (personDtoDataGrid.SelectedItem is OrganisationDto per)
                    {
                        Print(new[] { per });
                    }
                }
                else if (sender == relationDtoDataGrid)
                {
                    if (relationDtoDataGrid.SelectedItem is OrganisationDto rel)
                    {
                        Print(new[] { rel });
                    }
                }
            }
            catch (Exception ex)
            {
                HandleEx(ex);
            }
        }

        private void UpdateView(string header)
        {
            try
            {
                if (header == OrganisationsTabItem.Header.ToString())
                {
                    if (this.FindResource("organisationDtoViewSource") is CollectionViewSource view)
                    {
                        this.organisations = api.Organisations()
                            .OrderBy(o => o.OrganisationName)
                            .ThenBy(o => o.OrganisationDivisionName);

                        view.Source = Filter(this.organisations);
                    }
                }
                else if (header == DupeOrganisationsTabItem.Header.ToString())
                {
                    if (this.FindResource("dupesOrganisationDtoViewSource") is CollectionViewSource dupesView)
                    {
                        this.dupes = api.OrganisationWithDuplicateVats()
                            .OrderBy(o => o.OrganisationExtraCustom1)
                            .ThenBy(o => o.OrganisationExtraCustom2)
                            .ThenBy(o => o.OrganisationName)
                            .ThenBy(o => o.OrganisationDivisionName);

                        //var path = @"c:\Users\Ole\Desktop\organisationDupes.csv";
                        //using (var file = new StreamWriter(path, false, Encoding.UTF8))
                        //{
                        //    file.WriteLine("CVR Number;Economic ID;Name;Division");
                        //    foreach (var dupe in dupes)
                        //    {
                        //        file.WriteLine($"{dupe.OrganisationExtraCustom1};{dupe.OrganisationExtraCustom2};{dupe.OrganisationName};{dupe.OrganisationDivisionName}");
                        //    }
                        //}

                        dupesView.Source = Filter(this.dupes);
                    }
                }
                else if (header == PersonsTabItem.Header.ToString())
                {
                    if (this.FindResource("personDtoViewSource") is CollectionViewSource view)
                    {
                        this.persons = api.Persons()
                            .OrderBy(p => p.PersonName);

                        view.Source = Filter(this.persons);
                    }
                }
                else if (header == RelationsTabItem.Header.ToString())
                {
                    if (this.FindResource("relationDtoViewSource") is CollectionViewSource view)
                    {
                        this.relations = api.Relations()
                            .OrderBy(r => r.RelationType);

                        view.Source = Filter(this.relations);
                    }
                }
            }
            catch (Exception ex)
            {
                HandleEx(ex);
            }
        }

        private BaseObject[] Filter(IEnumerable<BaseObject> baseObjects)
        {
            var filter = this.FilterTextBox.Text?.Trim().ToLowerInvariant();
            var results = string.IsNullOrWhiteSpace(filter)
                ? baseObjects.ToArray()
                : baseObjects.Where(b => -1 != b?.ToString().ToLowerInvariant().IndexOf(filter)).ToArray();

            //Print(results);

            return results;
        }

        private void OnFilterUpdated(object sender, EventArgs e)
        {
            timer.Stop();
            try
            {
                var newText = FilterTextBox.Text.TrimEnd();
                if (previousFilter == newText)
                {
                    if (OrganisationsTabItem.IsSelected == true)
                    {
                        if (this.FindResource("organisationDtoViewSource") is CollectionViewSource view)
                        {
                            view.Source = Filter(this.organisations);
                        }
                    }
                    else if (DupeOrganisationsTabItem.IsSelected == true)
                    {
                        if (this.FindResource("dupesOrganisationDtoViewSource") is CollectionViewSource view)
                        {
                            view.Source = Filter(this.dupes);
                        }
                    }
                    else if (PersonsTabItem.IsSelected == true)
                    {
                        if (this.FindResource("personDtoViewSource") is CollectionViewSource view)
                        {
                            view.Source = Filter(this.persons);
                        }
                    }
                    else if (RelationsTabItem.IsSelected == true)
                    {
                        if (this.FindResource("relationDtoViewSource") is CollectionViewSource view)
                        {
                            view.Source = Filter(this.relations);
                        }
                    }
                }
                else
                {
                    previousFilter = newText;
                    timer.Start();
                }
            }
            catch (Exception ex)
            {
                HandleEx(ex);
            }
        }

        private void FilterTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            timer.Stop();
            timer.Start();
        }

        private void FilterTextBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Escape)
            {
                e.Handled = true;
                FilterTextBox.Text = string.Empty;
            }
        }

        private void TabControl_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.Source is TabControl tabCtrl)
            {
                UpdateView((tabCtrl.SelectedItem as TabItem).Header.ToString());
            }
        }

        private void Print(IEnumerable<BaseObject> collection, string header = null)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(header))
                {
                    if (collection.Any())
                    {
                        if (collection.Count() == 1)
                        {
                            header = collection.First().GetType().Name;
                        }
                        else
                        {
                            header = $"IEnumerable<{collection.First().GetType().Name}>";
                        }
                    }
                    else
                    {
                        header = collection.GetType().Name;
                    }
                }
            }
            catch
            {
                header = "IEnumerable<BaseObject>";
            }
            json.Document.Blocks.Clear();
            json.Document.Blocks.Add(new Paragraph(new Run(header)));
            if (collection?.Any() == true)
            {
                var count = 1;
                foreach (var item in collection)
                {
                    if (collection.Count() > 1)
                    {
                        json.Document.Blocks.Add(new Paragraph(new Run($"({count++})")));
                    }
                    var tos = item != null ? item.ToString() : "null";
                    json.Document.Blocks.Add(new Paragraph(new Run(tos)));
                }
            }
            else
            {
                json.Document.Blocks.Add(new Paragraph(new Run("empty")));
            }
        }

        private void HandleEx(Exception ex)
        {
            try
            {
                Trace.TraceError(ex.ToString());
                Console.WriteLine(ex.ToString());

                if (ex is WebException wex && wex.Response is HttpWebResponse http)
                {
                    json.Document.Blocks.Add(new Paragraph(new Run($"\n\tNo result.\n\tStatus code: {http.StatusCode}")));
                    using (var webres = wex.Response)
                    {
                    }
                }
                json.Document.Blocks.Add(new Paragraph(new Run("\n\nException")));
                json.Document.Blocks.Add(new Paragraph(new Run(ex.ToString())));
            }
            catch
            {
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Load data by setting the this.GridViewSource.Source property:
            this.OrganisationsTabItem.IsSelected = true;

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            api?.Dispose();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            ((CollectionViewSource)this.FindResource("organisationDtoViewSource")).Source = null;
            ((CollectionViewSource)this.FindResource("selectedOrganisationDtoViewSource")).Source = null;
            ((CollectionViewSource)this.FindResource("dupesOrganisationDtoViewSource")).Source = null;
            ((CollectionViewSource)this.FindResource("personDtoViewSource")).Source = null;
            ((CollectionViewSource)this.FindResource("relationDtoViewSource")).Source = null;
        }
    }
}
