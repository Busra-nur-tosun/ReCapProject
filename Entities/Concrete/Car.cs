using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
     public  class Car
    {
        public int Id { get; set; }
        public int BrandId { get; set; }//brand= marka
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }//günlük fiyat
        public string  Description { get; set; }


    }
}
