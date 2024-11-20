using EFCoreTesting.DAL;
using EFCoreTesting.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;


Console.WriteLine("Hello");
// Setup Dependency Injection
var serviceProvider = new ServiceCollection()
    .AddDbContext<TestDbContext>()
    .AddScoped<ITestRepository, TestRepository>()
    .BuildServiceProvider();

// Ensure the database is created
using (var scope = serviceProvider.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<TestDbContext>();
    dbContext.Database.EnsureCreated();
}

// Resolve the service and perform operations
var testRepository = serviceProvider.GetRequiredService<TestRepository>();

Console.WriteLine("Fetching Users...");
var users = testRepository.GetUsers();

foreach (var user in users)
{
    Console.WriteLine($"-{user.FirstName} {user.LastName}");
}

Console.ReadKey();
