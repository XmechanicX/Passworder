using System.Collections.Specialized;
using System.Text.Json.Serialization;

namespace Passworder.Model
{
    public class DataFilling
    {
        public DataFilling() { }
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Website { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }
}
