namespace MYAcademy_Portfolio.Entities
{
    public class Education
    {
        public int EducationId { get; set; }
        public string Title  { get; set; }
        public string? SubTitle  { get; set; } //altı yeşil çizilen boş geçilemez demektir boş geçmek istersem ? koyarım
        public string Description { get; set; }
        public string Duration { get; set; } //Süre

    }
    //degisken,Field,Property
}
