﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car {Id=1, BrandId=1, ColorId=1, DailyPrice=200,ModelYear=2013,Description="Yaris",},
            new Car {Id=2, BrandId=2, ColorId=3, DailyPrice=250,ModelYear=2017,Description="Golf",},
            new Car {Id=3, BrandId=1, ColorId=1, DailyPrice=280,ModelYear=2015,Description="Auris",},
            new Car {Id=4, BrandId=1, ColorId=1, DailyPrice=200,ModelYear=2013,Description="Corolla",},
            new Car {Id=5, BrandId=2, ColorId=1, DailyPrice=300,ModelYear=2018,Description="Polo",},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);    
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(p=>p.BrandId==BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
