using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Abstract
{
    public  interface ICarDal
    {
        void Update(Car car);
        void Delete(Car car);
        void Add(Car car);
        List<Car> GetAll();
        List<Car> GetAllByBrand(int brandId);
    }
}
