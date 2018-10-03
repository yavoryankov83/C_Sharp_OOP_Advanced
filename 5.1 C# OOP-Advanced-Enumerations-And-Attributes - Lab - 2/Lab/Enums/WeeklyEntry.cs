using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public class WeeklyEntry : IComparable<WeeklyEntry>
    {
        public WeeklyEntry(string weekday, string notes)
        {
            this.WeekDay = (Weekday)Enum.Parse(typeof(Weekday), weekday);
            this.Notes = notes;
             
        }

        public Weekday WeekDay { get; private set; }
        public string Notes { get; private set; }

        public int CompareTo(WeeklyEntry other)
        {
            if (ReferenceEquals(this, other))
            {
                return 0;
            }
            if (ReferenceEquals(null, other))
            {
                return 1;
            }
            var weekDayComparison = WeekDay.CompareTo(other.WeekDay);
            if (weekDayComparison != 0)
            {
                return weekDayComparison;
            }

            return string.Compare(Notes, other.Notes, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"{this.WeekDay} - {this.Notes}";
        }
    }
}
