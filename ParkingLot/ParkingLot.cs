﻿namespace ParkingLot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ParkingLot
    {
        private Dictionary<string, Car> parkedCars = new Dictionary<string, Car>();
        private int parkingCapicity;

        public ParkingLot(int parkingCapicity = 10)
        { 
            this.parkingCapicity = parkingCapicity;
        }

        public void ParkCar(Car car)
        {
            CheckValidCar(car);
            CheckCapicity();
            parkedCars.Add(car.CarID, car);
        }

        private void CheckValidCar(Car car)
        {
            if (parkedCars.Values.Contains(car))
            {
                throw new WrongCarException();
            }
        }
        private void CheckCapicity()
        {
            if (parkingCapicity - parkedCars.Count == 0)
            {
                throw new NoPositionException("Not enough position.");
            }
        }

        public Car FetchCar(string carID)
        {
            Car feachedCar = parkedCars[carID];
            parkedCars.Remove(carID);
            return feachedCar;
        }

    }



    

}
