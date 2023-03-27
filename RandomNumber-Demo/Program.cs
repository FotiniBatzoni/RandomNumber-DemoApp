

using RandomNumber_Demo;

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            // Console.WriteLine(random.Next(5,11));

            //Console.WriteLine(random.NextDouble()*10);

            //SimpleMethod.ShowRandom(random);

        }


        List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel() {FirstName = "Tim"},
                new PersonModel() {FirstName = "Tom"},
                new PersonModel() {FirstName = "Sue"},
                new PersonModel() {FirstName = "Lee"},
                new PersonModel() {FirstName = "Jim"},
                new PersonModel() {FirstName = "Mary"},
                new PersonModel() {FirstName = "Bob"},
            };

        var sortedPeople = people.OrderBy(x => random.Next());

        foreach (var p in sortedPeople)
        {
            Console.WriteLine(p.FirstName);

        }

        Console.ReadLine();
    }
}