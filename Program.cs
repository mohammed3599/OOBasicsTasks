namespace OOBasicsTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book Bk01 = new Book("Animals", "Mohammed Al Mamari", 2022);

            Console.WriteLine("Book Data ....");
            Console.WriteLine("Title: " +  Bk01.title);
            Console.WriteLine("Author: " + Bk01.author);
            Console.WriteLine("Year: " + Bk01.year);
            Console.WriteLine();
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||");

            Circle Cr01 = new Circle(5);
            Console.WriteLine();
            Console.WriteLine("Circle Data ....");
            Console.WriteLine("The radius: " + Cr01.radius);
            Console.WriteLine("The Area of circle: " + Cr01.calArea(Cr01.radius));
        }
    }
}