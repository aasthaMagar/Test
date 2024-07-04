namespace Formula1.Models
{
    public class UserInfo
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Address {  get; set; }

        public int UserId {  get; set; }
        public required int Number {  get; set; }
        public string? Nationality { get; set; }
        public required gender Gender { get; set; }
        public required DateOnly DateOfBirth { get; set; }
        //public T? Data { get; set; }
    }

    public enum gender
    {
        Male, Female, Binary, Other
    }

    public class Detail : UserInfo
    {
        public required string Position { get; set; }
        public required int Income { get; set; }
        public required String InstituteName { get; set; }
        public required DateOnly Joindate { get; set; }

        public required status Status { get; set; }
    }

    public enum status
    {
        Single, Married
    }


}
