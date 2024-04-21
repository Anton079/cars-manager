using cars_manager;

internal class Program
{
    private static void Main(string[] args)
    {
        UserService userService = new UserService();
        
        User user = new User(6, "gerge@gmail.com", "gegr", 07653464);

        userService.AddUser(user);

        userService.SaveData();
    }
}