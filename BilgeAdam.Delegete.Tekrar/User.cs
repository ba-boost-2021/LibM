namespace BilgeAdam.Delegate.Tekrar
{
    public class User
    {
        public event NewUserEventHandler onCreateUser;
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public void CreateNewUser(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;

            onCreateUser.Invoke(this);
        }
    }
    public delegate void NewUserEventHandler(User payload);
}