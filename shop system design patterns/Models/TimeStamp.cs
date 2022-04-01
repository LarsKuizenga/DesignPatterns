
namespace FrenchutoShop.Models
{
    /// <summary>
    /// Keeps track of current time and day in the store.
    /// </summary>
    class TimeStamp
    {
        public int DayCount { get; set; }
        public int CurrHour { get; set; }
        public int MinHour { get; set; }
        public int MaxHour { get; set; }

        public TimeStamp(int dayCount, int minHour, int maxHour)
        {
            this.DayCount = dayCount;
            this.CurrHour = minHour;
            this.MinHour = minHour;
            this.MaxHour = maxHour;
        }

        public bool IsStartDay()
        {
            return CurrHour == MinHour;
        }

        public string StartDay()
        {
            return $"Day {DayCount} starts";
        }

        public bool IsEndOfDay()
        {
            return CurrHour > MaxHour;
        }

        public string EndDay()
        {
            string returnString = $"Day {DayCount} ends";
            CurrHour = MinHour;
            DayCount++;
            return returnString;
        }

        public void UpdateHour()
        {
            CurrHour++;
        }
    }
}
