namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string UserName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}