using F1Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace F1Model.Interfaces
{
    public interface IDriverProvider
    {
        Task<IEnumerable<Driver>> GetDrivers();
    }
}
