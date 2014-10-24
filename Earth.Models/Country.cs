namespace Earth.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Country
    {
        private ICollection<Town> towns;

        public Country()
        {
            this.towns = new HashSet<Town>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Language { get; set; }

        public decimal Population { get; set; }

        public int ContinendId { get; set; }

        public virtual Continent Continent { get; set; }

        public virtual ICollection<Town> Towns
        {
            get
            {
                return this.towns;
            }
            set
            {
                this.towns = value;
            }
        }
    }
}