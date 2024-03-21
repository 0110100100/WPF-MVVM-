using System;

namespace WPF_MVVM_.Models
{
    public class ClientModel
    {
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Passport { get; set; }
        public DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
        public ModificationType ModificationType { get; set; }
    }

    public enum ModificationType
    {
        Added,
        Updated,
        Deleted
    }
}