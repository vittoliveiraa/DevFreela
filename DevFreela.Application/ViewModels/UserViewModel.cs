namespace DevFreela.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(string fullName, string email)
        {
            FullName = fullName;
            Email = email;  
        }

        public string Email { get; set; }
        public string FullName { get; set;}

    }
}
