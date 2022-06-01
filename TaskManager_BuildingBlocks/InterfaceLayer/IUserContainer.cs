using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface IUserContainer
    {
        public bool CheckUserExist(string email);

        public void Register(UserDTO dto);

        public void DeleteOne(UserDTO dto);

        public List<UserDTO> GetAll();

        public UserDTO GetUserById(int id);

        public UserDTO GetUserByEmail(string email);

        //public byte[] AddSalt()

        //public string hash(string pass, byte[] salt)
    }
}
