namespace Lab4 {
    internal class Program {
        static void Main(string[] args){

            //  Question 1
            Console.Write("Type in a number: ");
            string? shapeSides = Console.ReadLine();
            string shapeName;

            switch (shapeSides) {
                case "5":
                    shapeName = "Pentagon";
                    break;
                case "6":
                    shapeName = "Hexagon";
                    break;
                case "7":
                    shapeName = "Heptagon";
                    break;
                case "8":
                    shapeName = "Octagon";
                    break;
                default:
                    shapeName = "Other";
                    break;
            }

            Console.WriteLine(shapeName);

            //  Question 2
            for (int u = 3; u <= 87; u = u + 7) {
                Console.Write(u + " ");
            }

            //  Question 3
            int i = 3;
            while (i <= 87) {
                Console.Write(i + " ");
                i = i + 7;
            }

            //  Question 4
            Console.WriteLine("12 Midnight");
            for (int k = 1; k < 12; k++) {
                Console.WriteLine(k + "am");
            }
            Console.WriteLine("12 Noon");
            for (int l = 1; l < 12; l++) {
                Console.WriteLine(l + "pm");
            }

            //  Question 5
            double sum = 0;

            Console.Write("Type a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double j = 1;

            while (j < n + 1) {
                sum = sum + (1 / j);
                j++;
            }

            Console.WriteLine(sum);

            //  Question 6
            Random random = new Random();
            int count = 1;
            int dice = 6; 

            do {
                dice = random.Next(1, 7);
                Console.WriteLine(count + ". try        " + dice);
                count++;
            } while (dice != 6);

            Console.WriteLine("It came up after {0} tries.", count);

            //  Question 7
            Console.Write("How many numbers will you type: ");
            int numberCount = Convert.ToInt32(Console.ReadLine());
            int minOddNum = int.MaxValue;
            int currentNumber;

            for (int p = 1; p < numberCount + 1; p++) {
                Console.Write(p + ". Number: ");
                currentNumber = Convert.ToInt32(Console.ReadLine());
                if (currentNumber % 2 != 0 && currentNumber < minOddNum) {
                    minOddNum = currentNumber;
                }
            }

            if (minOddNum == 0) {
                Console.WriteLine("There are no odd numbers");
            }
            else {
                Console.WriteLine("The minimum odd number is " + minOddNum);
            }

            //  Question 8
            Console.Write("Type in a number between 1 and 9: ");
            string? number = Console.ReadLine();
            string numberType = "Not a valid number";

            switch (number) {
                case "1":
                case "4":
                case "9":
                    numberType = "Perfect Square";
                    break;
                case "2":
                case "6":
                case "8":
                    numberType = "Even Number";
                    break;
                case "3":
                case "5":
                case "7":
                    numberType = "Prime Number";
                    break;
            }

            Console.WriteLine(numberType);

            //  Question 9
            string countType;
            for (int b = 1; b < 11; b++) {
                switch (b) {
                    case 1:
                        countType = "st";
                        break;
                    case 2:
                        countType = "nd";
                        break;
                    case 3:
                        countType = "rd";
                        break;
                    default:
                        countType = "th";
                        break;
                }
                Console.WriteLine("Height at the {0}{1} hour= {2}", b, countType, 0.12 * b * b * b * b + 12 * b * b * b - 380 * b * b + 4100 * b + 220);
            }

            //  Question 10
            Random r = new Random();
            int randomNumber = r.Next(1, 100);

            int attempt = 1;

            Console.Write("Enter a number: ");
            int currNumber = Convert.ToInt32(Console.ReadLine());

            do {
                if (currNumber < randomNumber) {
                    Console.Write("Please enter a higher number: ");
                    currNumber = Convert.ToInt32(Console.ReadLine());
                }
                else if (currNumber > randomNumber) {
                    Console.Write("Please enter a lower number: ");
                    currNumber = Convert.ToInt32(Console.ReadLine());
                }

                attempt++;

            } while (currNumber != randomNumber);

            Console.WriteLine("You guessed the number after {0} attempts.", attempt);

            //  Question 11
            Console.Write("Type a number: ");
            int m = Convert.ToInt32(Console.ReadLine());
            double top = Math.PI;
            double bottom = 2;

            for (int a = 1; a < m + 1; a++) {
                top = top * (2 * a - 1);
                bottom = bottom * (2 * a);
            }

            Console.WriteLine(top / bottom);
        }

    }
}