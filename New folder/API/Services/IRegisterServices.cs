using API.Models;
using System.Threading.Tasks;

namespace API.Services
{
    public interface IRegisterServices
    {
        public  Task<string> RegisterUser(RegisterForm userForm);
    }
}
