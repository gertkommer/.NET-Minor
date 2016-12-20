// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Case2.MaRoWo.GarageAdministratie.Infrastructure.Agents.OnderhoudBeheerService.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class UpdateOnderhoudCommand
    {
        /// <summary>
        /// Initializes a new instance of the UpdateOnderhoudCommand class.
        /// </summary>
        public UpdateOnderhoudCommand() { }

        /// <summary>
        /// Initializes a new instance of the UpdateOnderhoudCommand class.
        /// </summary>
        public UpdateOnderhoudCommand(long onderhoudsId, string kenteken, int kilometerstand, string onderhoudsBeschrijving, bool hasApk, DateTime opdrachtAangemaakt)
        {
            OnderhoudsId = onderhoudsId;
            Kenteken = kenteken;
            Kilometerstand = kilometerstand;
            OnderhoudsBeschrijving = onderhoudsBeschrijving;
            HasApk = hasApk;
            OpdrachtAangemaakt = opdrachtAangemaakt;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "onderhoudsId")]
        public long OnderhoudsId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kenteken")]
        public string Kenteken { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kilometerstand")]
        public int Kilometerstand { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "onderhoudsBeschrijving")]
        public string OnderhoudsBeschrijving { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hasApk")]
        public bool HasApk { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opdrachtAangemaakt")]
        public DateTime OpdrachtAangemaakt { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Kenteken == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Kenteken");
            }
            if (OnderhoudsBeschrijving == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OnderhoudsBeschrijving");
            }
            if (this.Kilometerstand > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Kilometerstand", 2147483647);
            }
            if (this.Kilometerstand < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Kilometerstand", 0);
            }
        }
    }
}
