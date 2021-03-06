// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Csrs.Interfaces.Dynamics
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// This OData service is located at http://localhost
    /// </summary>
    public partial interface IDynamicsClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Show only the first n items
        /// </summary>
        int? Top { get; set; }

        /// <summary>
        /// Skip the first n items
        /// </summary>
        int? Skip { get; set; }

        /// <summary>
        /// Include count of items
        /// </summary>
        bool? Count { get; set; }

        /// <summary>
        /// Filter items by property values
        /// </summary>
        string Filter { get; set; }

        /// <summary>
        /// Search items by search phrases
        /// </summary>
        string Search { get; set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the ISharepointdocumentlocations.
        /// </summary>
        ISharepointdocumentlocations Sharepointdocumentlocations { get; }

        /// <summary>
        /// Gets the ISharepointsites.
        /// </summary>
        ISharepointsites Sharepointsites { get; }

        /// <summary>
        /// Gets the ISsgcsrsbccourtlevels.
        /// </summary>
        ISsgcsrsbccourtlevels Ssgcsrsbccourtlevels { get; }

        /// <summary>
        /// Gets the ISsgcsrschildren.
        /// </summary>
        ISsgcsrschildren Ssgcsrschildren { get; }

        /// <summary>
        /// Gets the ISsgcsrscommunicationmessages.
        /// </summary>
        ISsgcsrscommunicationmessages Ssgcsrscommunicationmessages { get; }

        /// <summary>
        /// Gets the ISsgcsrsfeedbacks.
        /// </summary>
        ISsgcsrsfeedbacks Ssgcsrsfeedbacks { get; }

        /// <summary>
        /// Gets the ISsgcsrsfiles.
        /// </summary>
        ISsgcsrsfiles Ssgcsrsfiles { get; }

        /// <summary>
        /// Gets the ISsgcsrsparties.
        /// </summary>
        ISsgcsrsparties Ssgcsrsparties { get; }

        /// <summary>
        /// Gets the ISsgijssbccourtlocations.
        /// </summary>
        ISsgijssbccourtlocations Ssgijssbccourtlocations { get; }

        /// <summary>
        /// Gets the ITasks.
        /// </summary>
        ITasks Tasks { get; }

    }
}
