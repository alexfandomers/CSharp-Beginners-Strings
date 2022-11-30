namespace StringBeginners
{
    public class Program
    {
        static void Main(string[] args)
        {  
            //concatenating
            var firstName = "karl";
            var lastName = "mosh";
            string names = string.Format("{0} {1}", firstName, lastName);
            //var names = firstName + lastName;
            //Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(names);

            //join method(separating by comma)
            var numbers = new int[3] {1, 2, 3};
            string list = string.Join(",", numbers);
            Console.WriteLine(list);

            //join method
            var names2 = new String[3] {"phill", "karl", "bill"};
            var separeted = string.Join(",", names2);
            Console.WriteLine(separeted);

            //Char
            string name = "Mosh";
            char firstChar = name[0];
            Console.WriteLine(firstChar);

            //verbatin
            var text = @"Hi karl look the paths 
            c:\folder\folder2
            c:\folder3\folder4";
            Console.WriteLine(text);                                    

        }
    }
}