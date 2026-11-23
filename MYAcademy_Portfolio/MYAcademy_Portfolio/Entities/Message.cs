namespace MYAcademy_Portfolio.Entities
{
    public class Message
    {
        public int MessageId { get; set; } //ıd sadece int olmak zorunda olmak değil **guid de olabilir
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string MessageDetail { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}
