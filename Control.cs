using System;

namespace hrc
{
    internal class Control
    {


        private string _Fname;
        private string _month, _day, _year;
            int _age, _maxHeartRate;

        public Control(String fName, string month, string day, string year)
        {

            SetFName(fName);
            SetDay(day);
            SetMonth(month);
            SetYear(year);
            GetAge();

        }

        public String GetfName()
        {

            return _Fname;

        }

        public void SetFName(String fName)
        {

            _Fname = fName;

        }

        public void SetDay(string day)
        {

            _day = day;

        }

        public void SetMonth(string month)
        {

            _month = month;

        }

        public void SetYear(string year)
        {

            _year = year;

        }

        public int GetAge()
        {
            // DateTime birth = DateTime.Parse("1.1.2000");
            DateTime birth = DateTime.Parse(_day + "." + _month + "." + _year);
            DateTime today = DateTime.Today;
            TimeSpan age = today - birth;
            double ageInDays=age.TotalDays;
            double daysInYear = 365.2425;
            double ageInYears = ageInDays / daysInYear;


            _age = (int)ageInYears;


            return _age;

        }

        public int GetMaxHeartRate()
        {

            _maxHeartRate = 220 - _age;
            return _maxHeartRate;

        }

        public int GetTargetHeartRate()
        {

            int halfOfHR = _maxHeartRate / 2;
            int targetHR = (halfOfHR / 50) * 100;
            return targetHR;

        }
    }
}