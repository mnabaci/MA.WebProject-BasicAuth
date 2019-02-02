using MA.Entity.Model.Model.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MA.Service.User
{
    public interface IUserService
    {
        Task<UserModel> Authenticate(string username, string password);
        Task<IEnumerable<UserModel>> GetAll();
    }
}
