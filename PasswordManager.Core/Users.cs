namespace PasswordManager.Core
{
    public class Users
    {
        private int Id { get; set; }

        private string Login {  get; set; } = string.Empty;

        private string Password { get; set; } = string.Empty;

        private DateOnly DateCreated { get; set; }
    }
}
