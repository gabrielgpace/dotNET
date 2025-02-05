using System;

namespace ExercicioEnum.Entities
{
    class HourContract
    {
        public DateTime Date {  get; set; }
        public double ValuePerHour;
        public double Hours;
        
        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, double hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
