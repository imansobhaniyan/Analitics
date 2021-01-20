using System.Collections.Generic;

namespace Ighan.Analitics.StorageModels
{
    public class Manufacturer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Device> Devices { get; set; }
    }
}
