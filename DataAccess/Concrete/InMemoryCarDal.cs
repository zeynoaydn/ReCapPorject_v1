using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=2,ColorId=3,DailyPrice=2,Description="deneme 1",ModelYear=2242},
                new Car{Id=1,BrandId=2,ColorId=3,DailyPrice=2,Description="deneme 2",ModelYear=4324},
                new Car{Id=1,BrandId=2,ColorId=3,DailyPrice=2,Description="deneme 3",ModelYear=545},
                new Car{Id=1,BrandId=2,ColorId=3,DailyPrice=2,Description="deneme 4",ModelYear=65},
                new Car{Id=1,BrandId=2,ColorId=3,DailyPrice=2,Description="deneme 5",ModelYear=24},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            _cars.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p=>p.Id==id).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate=_cars.SingleOrDefault(p=>p.Id == car.Id);
            carUpdate.Id = car.Id;
            carUpdate.BrandId= car.BrandId;
            carUpdate.ColorId= car.ColorId;
            carUpdate.DailyPrice= car.DailyPrice;
            carUpdate.Description= car.Description;
            carUpdate.ModelYear= car.ModelYear;
        }
    }
}
