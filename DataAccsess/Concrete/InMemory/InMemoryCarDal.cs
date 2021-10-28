using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccsess.Concrete.InMemory
{
      public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
             new Car { Id = 1, ColorId = 1, BrandId = 3, ModelYear = "2015", DailyPrice = 500,Description="Bmw 525d*Drive Premium 218 HP" },
            new Car { Id = 2, ColorId = 2, BrandId = 2, ModelYear = "2018", DailyPrice = 800,Description="Honda Civic 1.6i VTEC Eco Executive 125Hp"},
             
        };

    }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car cartoDelete=null;
            foreach (var c in _car)
            {
                if (car.Id == c.Id)
                {
                    cartoDelete = c;
                }

            }
            _car.Remove(cartoDelete);
        }

        public List<Car> GetAll()
        {
            return _car;   
        }

        public List<Car> GetAllByBrand(int brandId)
        {//select burda yazılır
            return _car.Where(c => c.BrandId == brandId).ToList();
           
        }

      

        public void Update(Car car)
        {//gönderdiğim ürüne ıs sine sahip olan ğürün idisini bul
            Car cartoUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            cartoUpdate.Id = car.Id;
            cartoUpdate.ModelYear = car.ModelYear;
            cartoUpdate.Description = car.Description;
            cartoUpdate.DailyPrice = car.DailyPrice;
            cartoUpdate.ColorId = car.ColorId;
            cartoUpdate.BrandId = car.BrandId;
            
        }
    }
       


      

      
    
}
