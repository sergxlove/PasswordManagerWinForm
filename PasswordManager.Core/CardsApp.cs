namespace PasswordManager.Core
{
    public class CardsApp
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Login { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Url {  get; set; } = string.Empty;

        public DateTime DateCreated { get; set; }
    }

    public class ListCardApp
    {
        public List<CardsApp> Cards { get; set; } = null!;
    }
}
