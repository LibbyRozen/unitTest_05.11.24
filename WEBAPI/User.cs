namespace WEBAPI
{
    public class User
    {
        private static int currentId = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
