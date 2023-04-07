using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1FirstApp
{
    internal class DogNew
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
    }
    public class DogCollection
    {
        public static void Main()
        {
            DogNew lucie=new DogNew();
            lucie.Id = 1;
            lucie.Name = "lucie";
            lucie.Age = 3;
            lucie.Breed = "Husky";
            lucie.Color = "White";
            lucie.Gender = "Male";

            DogNew kale = new DogNew();
            kale.Id = 2;
            kale.Name = "kale";
            kale.Age = 1;
            kale.Breed = "Husky";
            kale.Color = "White";
            kale.Gender = "Male";

            List<DogNew> list = new List<DogNew>();
            list.Add(lucie);
            list.Add(kale);

            DogNew result = list.Where(y => y.Age > 2).First();

            int[] marks = new int[5] { 60, 70, 32, 54, 70 };
            var StudentList=marks.OrderByDescending(x => x).ToArray();

        }
    }
}
