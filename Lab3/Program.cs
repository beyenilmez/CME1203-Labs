namespace Lab3 {
    internal class Program {
        static void Main() {

            //  Example 1
            Console.Write("Put in number 1: ");
            string? number1 = Console.ReadLine();
            Console.Write("Put in number 2: ");
            string? number2 = Console.ReadLine();

            if (number1 == number2) {
                Console.WriteLine("Yes");
            }
            else {
                Console.WriteLine("No");
            }

            //  Example 2
            Console.Write("Please put in an integer: ");
            string number3 = Console.ReadLine();
            bool number3State = Convert.ToInt32(number3) % 5 == 0;
            Console.WriteLine(number3State);

            //  Example 3
            Console.Write("Please put in hour: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please put in minutes: ");
            int minute = Convert.ToInt32(Console.ReadLine());

            string timeFormat = " AM";

            if (hour >= 13) {
                hour = hour - 12;
                timeFormat = " PM";
            }

            Console.WriteLine(hour + ":" + minute + timeFormat);

            //  Example 4
            Console.Write("Please put in your weight in kg: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please put in your height in m: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double index = weight / (height * height) * 100;

            if (index < 18.5) {
                Console.WriteLine("Thin");
            }
            else if (index < 25.0) {
                Console.WriteLine("Normal");
            }
            else if (index < 30.0) {
                Console.WriteLine("Fat");
            }
            else {
                Console.WriteLine("Obese");
            }


            //  Example 5
            Console.Write("Put in number 1: ");
            double me = Convert.ToDouble(Console.ReadLine());
            Console.Write("Put in number 2: ");
            double n = Convert.ToDouble(Console.ReadLine());

            if ((me + n) % 2 == 0) {
                Console.WriteLine(2 * me / (me * me - n * n));
            }
            else {
                Console.WriteLine("0");
            }


            //  Example 6
            Console.Write("Put in number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Put in number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Put in number 3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2 && num1 == num3) {
                Console.WriteLine("1 distinct value.");
            }
            else if ((num1 == num2 && num1 != num3) || (num1 == num3 && num1 != num2)) {
                Console.WriteLine("2 distinct values.");
            }
            else {
                Console.WriteLine("3 distinct values.");
            }


            //  Example 7
            Console.Write("Please put in a month:");
            string m = Console.ReadLine().ToLower();
            Console.Write("Please put in a day:");
            int d = Convert.ToInt32(Console.ReadLine());

            if ((m == "march" && d >= 21) || m == "april" || m == "may" || (m == "june" && d <= 20)) {
                Console.WriteLine("Spring");
            }
            else if ((m == "june" && d >= 21) || m == "july" || m == "august" || (m == "september" && d <= 22)) {
                Console.WriteLine("Summer");
            }
            else if ((m == "september" && d >= 23) || m == "october" || m == "november" || (m == "december" && d <= 21)) {
                Console.WriteLine("Fall");
            }
            else if ((m == "december" && d >= 21) || m == "january" || m == "february" || (m == "march" && d <= 20)) {
                Console.WriteLine("Winter");
            }
            else {
                Console.WriteLine("Error");
            }

            //  Example 8
            double diameter, velocity, density, viscosity;

            Console.Write("Please put in diameter: ");
            diameter = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please put in velocity: ");
            velocity = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please put in density: ");
            density = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please put in viscosity: ");
            viscosity = Convert.ToDouble(Console.ReadLine());

            double rNumber = diameter * velocity * density / viscosity / 100;

            if (rNumber < 2000) {
                Console.WriteLine("laminar flow");
                Console.WriteLine("\n {0} x {1} x {2} / {3} = {4}", density, velocity, diameter, viscosity, rNumber);
                Console.WriteLine("\nReynolds number is less than 2000, so the flow of liquid is laminar.");
            }
            else if (rNumber < 4000) {
                Console.WriteLine("transient flow");
                Console.WriteLine("\n {0} x {1} x {2} / {3} = {4}", density, velocity, diameter, viscosity, rNumber);
                Console.WriteLine("\nReynolds number is between 2000 and 4000, so the flow of liquid is transient.");
            }
            else {
                Console.WriteLine("turbulent flow");
                Console.WriteLine("\n {0} x {1} x {2} / {3} = {4}", density, velocity, diameter, viscosity, rNumber);
                Console.WriteLine("\nReynolds number is more than 4000, so the flow of liquid is turbulent.");
            }



        }
    }
}