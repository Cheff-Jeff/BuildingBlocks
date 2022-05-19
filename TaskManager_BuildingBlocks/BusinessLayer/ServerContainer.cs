using InterfaceLayer;
using InterfaceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ServerContainer
    {
        ISystemContainer ISystemContainer;

        public ServerContainer(ISystemContainer dal)
        {
            ISystemContainer = dal;
        }

        public List<Server> GetAllSystems()
        {
            //list aanmaken en vullen.
            List<Server> allsystems = new List<Server>();
            List<SystemDTO> list = ISystemContainer.GetAllSystems();
            foreach (SystemDTO system in list)
            {
                Server newsystem = new Server(system);
                allsystems.Add(newsystem);
            }
            return allsystems;
        }

        public Server GetOneSystemByName(Server system)
        {
            SystemDTO dto = system.ToDTO();

            Server sys = new Server();
            SystemDTO Dto = ISystemContainer.GetOneSystemByName(dto);
            sys.SystemId = Dto.SystemId;
            sys.SystemName = Dto.SystemName;

            return sys;
        }

        public Server GetOneSystemNameById(Server system)
        {
            SystemDTO dto = system.ToDTO();

            Server sys = new Server();
            SystemDTO Dto = ISystemContainer.GetOneSystemNameById(dto);
            sys.SystemId = Dto.SystemId;
            sys.SystemName = Dto.SystemName;

            return sys;
        }
    }
}
