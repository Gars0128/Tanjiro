﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Reporter
{
	internal class EmployeeReportDirector
	{
		private readonly IEmployeeReportBuilder _builder;

		public EmployeeReportDirector(IEmployeeReportBuilder builder)
		{
			_builder = builder;

		}
		public void Build ()
		{

			_builder
				.BuildHeader()
				.BuildBody()
				.BuildFooter();

           








		}
	}

}

