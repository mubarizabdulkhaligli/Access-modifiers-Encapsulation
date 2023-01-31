using System;
namespace task1
{
	internal class Student
	{
		public string FullName;
		int _age = 15;


		public int Age
		{
			set
			{
				if (value >= 15)
					_age = value;
			}
			get
			{
				return _age;
			}
		}
	}
}


