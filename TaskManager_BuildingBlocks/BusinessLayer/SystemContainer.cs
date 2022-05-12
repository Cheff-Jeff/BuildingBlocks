using InterfaceLayer;
using InterfaceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SystemContainer
    {
        ISystemContainer ISystemContainer;

        public SystemContainer()
        {

        }

        public SystemContainer(ISystemContainer dal)
        {
            ISystemContainer = dal;
        }

        public List<System> GetAllSystems()
        {
            //list aanmaken en vullen.
            List<System> allsystems = new List<System>();
            List<SystemDTO> list = ISystemContainer.GetAllSystems();
            foreach (SystemDTO system in list)
            {
                System newsystem = new System(system);
                allsystems.Add(newsystem);
            }
            return allsystems;
        }

        public System GetOneSystemByName(System system)
        {
            SystemDTO dto = system.ToDTO();

            System sys = new System();
            SystemDTO Dto = ISystemContainer.GetOneSystemByName(dto);
            sys.SystemId = Dto.SystemId;
            sys.SystemName = Dto.SystemName;

            return sys;
        }

        public System GetOneSystemNameById(System system)
        {
            SystemDTO dto = system.ToDTO();

            System sys = new System();
            SystemDTO Dto = ISystemContainer.GetOneSystemNameById(dto);
            sys.SystemId = Dto.SystemId;
            sys.SystemName = Dto.SystemName;

            return sys;
        }
    }
}
