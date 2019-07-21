using System;

namespace EF6DatabaseFirstDemo
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			using (var ctx = new DatabaseFirstDemoEntities())
			{
				var employee = new Employee()
				{
					FirstName = "Kyo",
					LastName = "Lai",
					HireDate = new DateTime(2017,7,1),
					Salary = 20000m
				};
				ctx.Employees.Add(employee);
				ctx.SaveChanges();
			}

			Console.WriteLine("Hello World!");
			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app!
		}
	}
}