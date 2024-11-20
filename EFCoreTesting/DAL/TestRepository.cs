using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreTesting.Interfaces;
using EFCoreTesting.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTesting.DAL
{
    internal class TestRepository : ITestRepository
    {
        private readonly TestDbContext _testDbContext;

        public TestRepository(TestDbContext testDbContext)
        {
            _testDbContext = testDbContext;
        }

        public IEnumerable<User> GetUsers()
        {
            return _testDbContext.User.ToList();
        }
    }
}
