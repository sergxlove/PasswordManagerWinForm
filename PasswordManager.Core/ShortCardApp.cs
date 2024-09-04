namespace PasswordManager.Core
{
    public class ShortCardApp
    {
        public int Id { get; set; }

        public string NameService { get; set; } = string.Empty;

        public DateTime DateUpdate { get; set; } = DateTime.MinValue;
    }

    public class ListShortCardApp
    {
        public List<ShortCardApp> ShortCards { get; set; } = null!;
    }

}


