namespace Types
{
    public static class Homework
    {
        public static void QuestA()
        {
            Console.WriteLine("Please, enter text:");
            string[] str = Console.ReadLine().Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Please, enter char:");
            char symbol = Convert.ToChar(Console.ReadLine());

            try
            {
                var result = str.SingleOrDefault(x => x.Length != 0 && x[x.Length - 1] == symbol) ?? "null"; //we can use string.Empty or null
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void QuestB()
        {
            Console.WriteLine("Your array:");
            int[] array = { 5, 8, 0, -1, 6, 4, -1, -3 };
            foreach (var item in array)
            {
                Console.Write($"{item} | ");
            }
            Console.WriteLine();

            List<int> list = array.Where(x => x >= 0).ToList();
            Console.WriteLine("New array:");
            foreach (var item in list)
            {
                Console.Write($"{item} | ");
            }
            Console.WriteLine();

            var resault = list.Average();
            Console.WriteLine($"Average new array is <{resault}>");
        }
        public static void QuestC()
        {
            string str = "Женя скоро будет свободен, а у вас все только начинается";
            Console.WriteLine("First string:\n" + str);
            char g = 'о';

            string res = string.Empty;
            res = String.Concat(str.Where(x => x != g));
            Console.WriteLine("New string:\n" + res);
        }
        public static void QuestD()
        {
            Console.WriteLine("Join:");
            string res = String.Join(" ", GetAlphabet(true).Where(letter =>
                     letter.CompareTo("A") >= 0));
            Console.WriteLine(res);
            static List<string> GetAlphabet(bool upper)
            {
                List<string> alphabet = new List<string>();
                int charValue = upper ? 65 : 97;
                for (int ctr = 0; ctr <= 25; ctr++)
                    alphabet.Add(((char)(charValue + ctr)).ToString());
                return alphabet;
            }
            Console.WriteLine();

            Console.WriteLine("Where:");
            List<string> fruits = new List<string> { "apple", "passionfruit", "banana", "mango",
                    "orange", "blueberry", "grape", "strawberry" };

            IEnumerable<string> query = fruits.Where(fruit => fruit.Length < 6);
            foreach (string fruit in query)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine();

            Console.WriteLine("Take:");
            int[] grades = { 59, 82, 70, 56, 92, 98, 85 };
            IEnumerable<int> topThreeGrades = grades.OrderByDescending(grade => grade).Take(3);
            Console.WriteLine("The top three grades are:");
            foreach (int grade in topThreeGrades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine();

            Console.WriteLine("Skip:");
            IEnumerable<int> lowerGrades = grades.OrderByDescending(g => g).Skip(3);
            Console.WriteLine("All grades except the top three are:");
            foreach (int grade in lowerGrades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine();

            Console.WriteLine("Select:");
            IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);
            foreach (int num in squares)
            {
                Console.WriteLine(num);
            }
        }
    }
}