using CarStore.Models.Requests;
using CarStore.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.BL.Interfaces
{
    public interface ILibraryService
    {
        GetAllCarsByBrandResponse?
            GetAllCarsByBrandAfterDate(
                GetAllCarsByBrandRequest request);

        int GetAllCarsCount(int inputCount, int carId);
    }
}
