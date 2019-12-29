using System;

namespace ValueTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            //value tuples can include more than 8 values. unlike tuples
            ValueTuple<int, string, string> mbada = (1, "Bill", "Gates");

            (int Id, string FirstName, string LastName) person = (1, "Bill", "Gates");
            Console.WriteLine(person.Id);

            var bourgeosie = (Id: 1, FirstName: "Jeff", LastName: "Benzo");

        }
    }
}
