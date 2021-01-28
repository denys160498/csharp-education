using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace YieldOperator
{
    class Week
    {
        string[] days;

        public Week()
        {
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            days = weekDays;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < days.Length; i++)
            {
                yield return days[i];
            }
        }

        public IEnumerable GetAmericanWeek()
        {
            yield return days[days.Length - 1];

            for (int i = 0; i < days.Length - 1; i++)
            {
                yield return days[i];
            }
        }
    }
}
