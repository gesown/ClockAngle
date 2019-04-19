using System;

namespace ClockAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: ClockAngle Minutes Hour -> Writes angle of separation (degrees).");
                return;
                ;
            }
            var alpha = 0m; //  hour hand angle in degrees
            var partHour = 360m / 12m;
            var delHour = 0m; // fraction of hour
            var beta = 0m; // minute hand angle in degrees
            var gamma = 0m; // angle between hands in degrees
            var minutes = args[0];
            var hour = args[1];
            alpha = (decimal.Parse(hour) / 12m) * 360m; // fraction of circle

            beta = (decimal.Parse(minutes) / 60) * 360; // fraction of circle
            delHour = partHour * beta / 360;
            gamma = alpha - beta - delHour; // fraction of circle
            Console.WriteLine("Angle of Separation: " + gamma.ToString("0.00"));
        }
    }
}
