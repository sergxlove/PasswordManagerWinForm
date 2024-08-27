namespace PasswordManager.Core
{
    public class CardsApp
    {
        private int Id {  get; set; }

        private string Name { get; set; } = string.Empty;

        private string Login { get; set; } = string.Empty;

        private string Password { get; set; } = string.Empty;

        private string Description { get; set; } = string.Empty;

        private string Url {  get; set; } = string.Empty;

        private DateTime DateCreated { get; set; }
    }
}
