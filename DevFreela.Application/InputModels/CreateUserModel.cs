

namespace DevFreela.Application.InputModels
{
    public class CreateUserModel
    {
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public bool Active { get; set; }
    }
}
