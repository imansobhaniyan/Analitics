namespace Ighan.Analitics.StorageModels
{
    public class Device
    {
        public long Id { get; set; }

        public int BrandId { get; set; }

        public int ManufacturerId { get; set; }

        public string Model { get; set; }

        public string Release { get; set; }

        public int SDK { get; set; }

        public Brand Brand { get; set; }

        public Manufacturer Manufacturer { get; set; }
    }
}
