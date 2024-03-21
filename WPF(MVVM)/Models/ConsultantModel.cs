using System;

namespace WPF_MVVM_.Models
{
    public class ConsultantModel
    {
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; private set; }
        private string _phone;
        public string Phone
        {
            get => _phone;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("phone number cannot be empty");
                }
                _phone = value;
            }
        }
        private string _passport;
        public string Passport
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_passport))
                {
                    return "******************";
                }
                return _passport;
            }
            set => _passport = value;
        }
        public DateTime LastModified { get; set; }
        public ModificationType ModificationType { get; set; }
        public string ModifiedBy { get; set; }
    }
}