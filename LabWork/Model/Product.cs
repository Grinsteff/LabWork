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


    }
}
