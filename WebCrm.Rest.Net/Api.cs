using System;
using System.Collections.Generic;
using System.Linq;
using WebCrm.Rest.Model;

namespace WebCrm.Rest.Net
{
    public class Api : IDisposable
    {
        public RestClient Client { get; } = new RestClient();

        #region API Methods

        /// <returns>Modtag alle OrganisationDto</returns>
        public IEnumerable<OrganisationDto> Organisations()
        {
            Client.UpdateLogin();
            return Client.GET<OrganisationDto>("Organisations");
        }

        public IEnumerable<OrganisationDto> OrganisationWithDuplicateVats()
        {
            Client.UpdateLogin();

            var dupes = Organisations()
                .GroupBy(o => o.OrganisationVatNumber)
                .Where(g => g.ToList().Count() > 1)
                .SelectMany(o => o.ToList())
                .Distinct();

            return dupes;
        }

        /// <returns>Modtag en OrganisationDto med det angivne ID</returns>
        public OrganisationDto Organisation(int id)
        {
            Client.UpdateLogin();
            return Client.GET<OrganisationDto>("Organisations", id);
        }

        /// <returns>Modtag alle PersonDto</returns>
        public IEnumerable<PersonDto> Persons()
        {
            Client.UpdateLogin();
            return Client.GET<PersonDto>("Persons");
        }

        /// <returns>Modtag en PersonDto med det angivne ID</returns>
        public PersonDto Person(int id)
        {
            Client.UpdateLogin();
            return Client.GET<PersonDto>("Persons", id);
        }

        /// <returns>Modtag alle RelationDto'er</returns>
        public IEnumerable<RelationDto> Relations()
        {
            Client.UpdateLogin();
            return Client.GET<RelationDto>("Relations");
        }

        /// <returns>Modtag en RelationDTO med det angivne ID</returns>
        public RelationDto Relation(int id)
        {
            Client.UpdateLogin();
            return Client.GET<RelationDto>("Relations", id);
        }

        #endregion

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Client.Dispose();
                }

                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
        }

        #endregion


    }
}
