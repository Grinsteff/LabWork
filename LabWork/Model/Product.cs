using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Media.Imaging;

namespace LabWork.Model
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public string Desc { get; set; }
        public Product(string Name, double? Price, string Desc) 
        {
            this.Name = Name;
            this.Price = Price;
            this.Desc = Desc;
            this.QRCode = QRGenerator.QRCoder(Name, Desc, Price);
        }
        [NotMapped]
        public BitmapImage QRCode { get; set; }

    }
}
