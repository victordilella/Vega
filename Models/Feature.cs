using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vega.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [Required]
        [StringLength(512)]
        public string Name { get; set; }

    }
}