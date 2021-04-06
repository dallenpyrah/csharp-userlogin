namespace morning_challenge.Models
{
    public class User
    {
        public string Name { get; set; }

        public string Password { get; set; }

        // public string Password { get; private set;}
        // This means that anyone can get the password but only you can set it 
    }
}