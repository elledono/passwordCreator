namespace passwordCreator
{
    internal class passwordCreator
    {
        static void Main(string[] args)
        {
            int length = 0;
            int minlength = 8;
            int maxlength = 32;
            Console.WriteLine("Please enter the desired length of your password(s): ");
            length = int.Parse(Console.ReadLine());
            while(length < minlength || length > maxlength) {
                Console.WriteLine("Your password must be at least " + minlength + " characters and at most " + maxlength + " characters. Please enter another length in this range: ");
                length = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please enter the number (1-10) of passwords you'd like generated:  ");
            int numPasswords = int.Parse(Console.ReadLine());
            if (numPasswords < 1 || numPasswords > 10) {
                Console.WriteLine("Your resquested amount of passwords was not within the appropriate range.");
                return;
            }
            Console.WriteLine("Here is your randomly generated password(s): ");
            for (int j = 0; j < numPasswords; j++) {
                string password = "";
                for (int i = 0; i < length; i++)
                {
                    password += randomChar().ToString();
                }
                Console.WriteLine(password);
            }
        }

        private static char randomChar() {
            Random random = new Random();
            int min = 33;
            int max = 122;
            int asciiCode = random.Next(min, max);
            return (char)asciiCode;
        }
    }
}
