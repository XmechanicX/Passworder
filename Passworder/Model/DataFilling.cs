namespace Passworder.Model
{
    public class DataFilling
    {
        public Guid Id { get; set; }
        public string Website { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;

        // Простейший ToString для отладки / списка
        public override string ToString() => $"{Title} ({Login})";
    }
}
