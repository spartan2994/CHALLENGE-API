using System;
using NetCoreAPIMySQL.Model;

namespace NetCoreAPIMySQL.Data.Repositories
{
	public interface ICarRepository
	{
		Task<IEnumerable<Car>> GetAllCars();
        Task<Car> GetDetails(int id);
        Task<bool> InsertCar(Car car);
        Task<bool> UpdateCar(Car car);
        Task<bool> DeleteCar(Car car);
    }
}

