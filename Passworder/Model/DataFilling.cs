using System;
using System.Reflection.Emit;

namespace Passworder
{
    public class DataFilling
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Website { get; set; }
        public string Title { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Notes { get; set; }

        // Простейший ToString для отладки / списка
        public override string ToString() => $"{Title} ({Login})";
    }
}
