using System.Text.RegularExpressions;

namespace regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter email");
            String email = Console.ReadLine();// input is : ramtej5524@gmail.com
            Console.WriteLine("enter name");
            String name = Console.ReadLine();
            Console.WriteLine("enter DOB");
            String dob = Console.ReadLine();


            String pattern = "[a-z]{1,9}[0-9]{0,9}[@]{1}[a-z]{1,7}[.]{1}[a-z]{2,3}";
            string pattern1 = "[A-Z][a-z]";
            string pattern2 = "[0-9]{1,2}[/]{1}[0-9]{1,2}[/]{1}[0-9]{4}";
            bool b = Regex.IsMatch(email, pattern);
            bool b1 = Regex.IsMatch(name, pattern1);
            bool b2 = Regex.IsMatch(dob, pattern2);
            Console.WriteLine(b);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            
        }
    }
}
