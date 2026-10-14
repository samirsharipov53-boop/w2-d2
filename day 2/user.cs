class User
{
    public string FirsName{get ; set;}
    public string LastName{get ; set;}
    public string Username{get ; set;}
    public string PasswordHash{get ; set;}
    public bool IsLoggedIn{get ; set;}
    public DateTime CreatedAt{get ; set;}
    public User(string firstName, string lastName, string username, string password)
    {
        FirsName = firstName;
        LastName = lastName;
        Username = username;
        PasswordHash = password;
        IsLoggedIn = false;
        CreatedAt = DateTime.Now;
    }
    public void Login(string username, string password)
    {
        if(Username==username && PasswordHash == password)
        {
            IsLoggedIn=true;
            Console.WriteLine("Добро пожаловать, FirstName!");
        }
        else
        {
            Console.WriteLine("Ошибка входа: проверьте логин или пароль.");
        }
    }
    public void Logout()
    {
        IsLoggedIn=false;
        Console.WriteLine("Вы вышли из системы");
    }
    public string GetFullinfo()
    {
        return$"{FirsName} {LastName} {Username} {PasswordHash} {IsLoggedIn} {CreatedAt}";
    }
    public void ChangePassword(string aldPassword, string newPassword)
    {
        if (PasswordHash == aldPassword)
        {
            PasswordHash=newPassword;
            Console.WriteLine("Пароль изменён.");
        }
    }
    public int GetAccountAgeInDays()
    {
        return (DateTime.Now-CreatedAt).Days;
    }
}