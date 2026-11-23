using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MYAcademy_Portfolio.Entities
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string GithubUrl { get; set; }
        public string CoverImageUrl { get; set; }

        public int CategoryId { get; set; }

     
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}