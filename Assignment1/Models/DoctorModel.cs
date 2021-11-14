namespace Assignment1.Models
{
    public class DoctorModel
    {
        public static string FeverCheck(float temperature)
        {
            if (temperature < 37 || temperature > 37.7)
            {
                return "You do have a fever!";
            }

            return "You do not have a fever";
        }
    }
}