using InterfaceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface ISystemContainer
    {
        public List<SystemDTO> GetAllSystems();

        public SystemDTO GetOneSystemByName(SystemDTO dto);

        public SystemDTO GetOneSystemNameById(SystemDTO dto);
    }
}
