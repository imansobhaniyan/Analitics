using System;
using System.Collections.Generic;
using System.Text;

namespace Ighan.Analitics.StorageModels
{
    public class Brand
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Device> Devices { get; set; }
    }
}
