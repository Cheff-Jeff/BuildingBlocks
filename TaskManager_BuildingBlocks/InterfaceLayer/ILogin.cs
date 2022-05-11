using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface ILogin
    {
        public List<LoginDTO> GetUserByEmail(LoginDTO dto);

        public bool LoginUserCheck(LoginDTO dto);
    }
}
