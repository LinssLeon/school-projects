using System;
namespace DateCheckerApp
{
	public class ValidDateCheck
	{
		public bool ValidDate(int day, int month, int year)
		{
			int[] monthDays = new int[] {31,28,31,30,31,30,31,31,30,31,30,31};

			if (year < 0 || year > 10000)
			{
				return false;
			}
			if (month < 1 || month > 12)
			{
				return false;
			}
			if (month == 2 && year % 4 == 0 || year % 400 == 0 && year % 100 != 0)
			{
				monthDays[1] = 29;
			}
			if (monthDays[month] < day || day < 1)
			{
				return false;
			}
			return true;
		}
	}
}

