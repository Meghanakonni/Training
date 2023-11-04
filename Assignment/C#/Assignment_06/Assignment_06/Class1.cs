using System;
namespace Assignment6
{
    public class FareConcessionCalculator
    {
        private const int TotalFare = 500; //500 is a constant value
        public static string CalculateConcession(int age, string name)
        {
            if (age <= 5)
            {
                return $"{name} - Little Champs - Free Ticket (Age: {age})";
            }
            else if (age > 60)
            {
                double concessionAmount = TotalFare * 0.3; // discount on the fare
                double discountedFare = TotalFare - concessionAmount;
                return $"{name} - Senior Citizen (Age: {age}) - Calculated Fare: {discountedFare:C}";
            }
            else
            {
                return $"{name} - Ticket Booked - Fare: {TotalFare:C} (Age: {age})";
            }
        }
    }
}