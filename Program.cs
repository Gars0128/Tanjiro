using Reporter;

List<Empployee> employees = new()
{
    new Empployee {Name = "Ivan", Salary = 100},
    new Empployee {Name = "Boris", Salary = 50},
    new Empployee {Name = "Fedor", Salary = 200}

};

var builder = new EmployeeReportBuilder(employees);

var director = new EmployeeReportDirector(builder);

director.Build();

var report = builder.GetReport();

Console.WriteLine(report);

Console.ReadKey();