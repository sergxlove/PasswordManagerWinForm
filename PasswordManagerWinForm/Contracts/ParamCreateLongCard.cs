namespace PasswordManagerWinForm.Contracts
{
    public class ParamCreateLongCard
    {
        public ParamCreateLongCard(int id, string name, string login,  string password, string description, string url, DateTime dateCreated)
        {
            Id = id;
            Name = name;
            Login = login;
            Password = password;
            Description = description;
            Url = url;
            DateCreated = dateCreated;
        }

        public int Id;
        public string Name;
        public string Login;
        public string Password;
        public string Description;
        public string Url;
        public DateTime DateCreated;

    }
}
