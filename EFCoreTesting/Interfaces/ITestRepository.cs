using EFCoreTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTesting.Interfaces
{
    internal interface ITestRepository
    {
        IEnumerable<User> GetUsers();
    }
}
