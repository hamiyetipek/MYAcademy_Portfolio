using MYAcademy_Portfolio.Entities;
using System.ComponentModel.DataAnnotations;

namespace MYAcademy_Portfolio.Entities
{
    public class Skill
    {
        public int SkillId { get; set; }

        [Required(ErrorMessage = "Yetenek adı boş geçilemez.")]
        public string Name { get; set; } = string.Empty;   

        [Range(5, 100, ErrorMessage = "Yetkinlik seviyesi %5 ile %100 arasında olmalı.")]
        public int Percentage { get; set; }                

        public int SkillCategoryId { get; set; }
        public SkillCategory? SkillCategory { get; set; }
    }
}