using WPF_MVVM_.Models;

public class ManagerModel : ConsultantModel
{   
    public new string LastName { get; set; }
    public new string Name { get; set; }
    public new string Patronymic { get; set; }
    public new string Phone { get; set; }
    public new string Passport { get; set; }
}

public enum ModificationType
{
    Added,
    Updated,
    Deleted
}
