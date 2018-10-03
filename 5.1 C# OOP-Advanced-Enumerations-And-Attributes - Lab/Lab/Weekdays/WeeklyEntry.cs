using System;

namespace Weekdays
{
    public class WeeklyEntry : IComparable<WeeklyEntry>
    {
        public WeeklyEntry(string weekday, string notes)
        {
            this.WeekDay = (WeekDay)Enum.Parse(typeof(WeekDay), weekday);
            this.Notes = notes;
        }

        public WeekDay WeekDay { get; private set; }

        public string Notes { get; private set; }

        public int CompareTo(WeeklyEntry other)
        {
            var comparison = this.WeekDay.CompareTo(other.WeekDay);

            if (comparison != 0)
            {
                return comparison;
            }

            var comparison2 = this.Notes.CompareTo(other.Notes);

            if (comparison2 != 0)
            {
                return comparison2;
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{this.WeekDay} - {this.Notes}";
        }
    }
}