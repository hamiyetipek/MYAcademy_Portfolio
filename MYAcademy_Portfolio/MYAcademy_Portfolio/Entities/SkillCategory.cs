using System.ComponentModel.DataAnnotations;

namespace MYAcademy_Portfolio.Entities
{
    public class SkillCategory
    {
        public int SkillCategoryId { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty; 
        public string Icon { get; set; } = string.Empty;         
        public string Color { get; set; } = string.Empty;       
        public int DisplayOrder { get; set; }                  
        public List<Skill> Skills { get; set; } = new();
    }
}