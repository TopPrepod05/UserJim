namespace KAKTO;


class User
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public User(string name, string email, string password)
    {
        Username = name;
        Password = password;
        Email = email;
        System.Console.WriteLine($"{Username} создан!");
    }

    public User() : 
        this("Данил Колбасенко", "danilkolbasenko@kolbasa.russkiy", "superdanil") {}

}