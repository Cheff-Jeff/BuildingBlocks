using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_BuildingBlocks
{
    internal class PcData
    {
        public List<int> id { get; private set; } = new List<int>();
        public List<int> CPU { get; private set; } = new List<int>();
        public List<int> GPU { get; private set; } = new List<int>();
        public List<int> Ram { get; private set; } = new List<int>();
        public List<int> Disk { get; private set; } = new List<int>();
        public List<int> Network { get; private set; } = new List<int>();

        public PcData()
        {

        }

        public PcData(List<int> id, List<int> cpu, List<int> gpu, List<int> ram, List<int> disk, List<int> network)
        {
            this.id = id;
            this.CPU = cpu;
            this.GPU = gpu;
            this.Ram = ram;
            this.Disk = disk;
            this.Network = network;
        }
    }
}
