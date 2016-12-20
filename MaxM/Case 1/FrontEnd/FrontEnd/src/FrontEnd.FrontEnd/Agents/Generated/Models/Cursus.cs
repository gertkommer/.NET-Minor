// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace FrontEnd.Agents.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class Cursus
    {
        /// <summary>
        /// Initializes a new instance of the Cursus class.
        /// </summary>
        public Cursus() { }

        /// <summary>
        /// Initializes a new instance of the Cursus class.
        /// </summary>
        public Cursus(string title, string cursusCode, DateTime startDate, int amountOfDays, int amountOfCursisten, int? id = default(int?))
        {
            Id = id;
            Title = title;
            CursusCode = cursusCode;
            StartDate = startDate;
            AmountOfDays = amountOfDays;
            AmountOfCursisten = amountOfCursisten;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cursusCode")]
        public string CursusCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "amountOfDays")]
        public int AmountOfDays { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "amountOfCursisten")]
        public int AmountOfCursisten { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Title == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Title");
            }
            if (CursusCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CursusCode");
            }
            if (this.Title != null)
            {
                if (this.Title.Length > 150)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Title", 150);
                }
            }
            if (this.CursusCode != null)
            {
                if (this.CursusCode.Length > 150)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "CursusCode", 150);
                }
            }
        }
    }
}
