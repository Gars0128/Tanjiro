using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Reporter
{
	public class EmployeeReportBuilder : IEmployeeReportBuilder
	{
		private EmployeeReport _employeeReport;

		private readonly IEnumerable<Empployee> _employees;

		public EmployeeReportBuilder(IEnumerable<Empployee> employees)
		{
			_employees = employees;
			_employeeReport = new();

		}
		public void BuildHeader()
		{
			_employeeReport.Header =
				$"EMPLOYEES REPORT ON DATE: {DateTime.Now}\n";

			_employeeReport.Header +=
				"\n-----------------------------------------\n";


        }
		public void BuildBody ()
		{
			 _employeeReport.Body=
				string.Join(Environment.NewLine,
				_employees.Select(e =>
				$"Employee: {e.Name}\t\tSAlary: {e.Salary}$"));
		}

		public void  BuildFooter ()
		{
			_employeeReport.Footer =
				"\n-----------------------------------------\n";

			_employeeReport.Footer +=
				$"\nTOTAL EMPLOYEES : {_employees.Count()}, " +

				$"TOTAL SALARY : {_employees.Sum(e => e.Salary)}$";

		}
		public EmployeeReport GetReport()
		{
            EmployeeReport employeeReport = _employeeReport;

			_employeeReport = new();


			return employeeReport;


		}



	}
}

