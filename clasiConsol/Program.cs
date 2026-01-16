namespace clasiConsol 
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookObject = new Book("Михаил Булгаков", "Мастер и Маргарита", 1967);
            bookObject.DisplayInfo();
        }
    }
}


