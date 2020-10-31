namespace Entity
{
    public class User
    {
        private long id;
        private string firstName;
        private string lastName;
        private string email;

        public User(long id, string firstName, string lastName, string email)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }
    }
}