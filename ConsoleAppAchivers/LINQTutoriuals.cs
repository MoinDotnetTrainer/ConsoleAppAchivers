using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }
    }

    internal class LINQTutoriuals
    {
        public static void Test()
        {
            // Select * from TblName
            // Select * from tbl where
            // select id,name from tblname
            int[] arr = { 354, 55, 6, 76, 77, 8, 9, 89, 90, 45, 56, 7, 67, 8, 787, 898, 9 };
            List<int> list = new List<int>() { 45, 57, 67, 87, 88, 99, 09, 45, 56 };

            var result = from s in arr
                         select s;  // common syntax
                                    // apply filters

            var res1 = from s in arr
                       where s > 50
                       select s;


            List<Student> listStudents = new List<Student>()
            {
                new Student{ID= 101,FirstName = "Preety",LastName = "Tiwary",Branch = "CSE",Age=35},
                new Student{ID= 102,FirstName = "Preety",LastName = "Agrawal",Branch = "ETC",Age=35},
                new Student{ID= 103,FirstName = "Priyanka",LastName = "Dewangan",Branch = "ETC",Age=46},
                new Student{ID= 104,FirstName = "Hina",LastName = "Sharma",Branch = "ETC",Age=45 },
                new Student{ID= 105,FirstName = "Anugrag",LastName = "Mohanty",Branch = "CSE",Age=45},
                new Student{ID= 106,FirstName = "Anurag",LastName = "Sharma",Branch = "CSE",Age=34},
                new Student{ID= 107,FirstName = "Pranaya",LastName = "Kumar",Branch = "CSE",Age=23},
                new Student{ID= 108,FirstName = "Manoj",LastName = "Kumar",Branch = "ETC",Age=33 },
                new Student{ID= 109,FirstName = "Pranaya",LastName = "Rout",Branch = "ETC",Age=34},
                new Student{ID= 110,FirstName = "Saurav",LastName = "Rout",Branch = "CSE",Age=23}
            };

            var myrec = (from s in listStudents select s).First(x => x.FirstName == "Preety");
            Console.WriteLine(myrec.ID);

            //foreach (var item in myrec)
            //{
            //    Console.WriteLine($"ID id {item.ID} name is {item.FirstName} lastname is {item.LastName} Branch id {item.Branch} and age is {item.Age}");
            //}

            List<Student> listStudents1 = new List<Student>()
            {
                new Student{ID= 111,FirstName = "Preety",LastName = "Tiwary",Branch = "CSE",Age=35},
                new Student{ID= 123,FirstName = "Preety",LastName = "Agrawal",Branch = "ETC",Age=35},
                new Student{ID= 145,FirstName = "Priyanka",LastName = "Dewangan",Branch = "ETC",Age=46},
                new Student{ID= 104,FirstName = "Hina",LastName = "Sharma",Branch = "ETC",Age=45 },
                new Student{ID= 105,FirstName = "Anugrag",LastName = "Mohanty",Branch = "CSE",Age=45},
                new Student{ID= 106,FirstName = "Anurag",LastName = "Sharma",Branch = "CSE",Age=34},
                new Student{ID= 107,FirstName = "Pranaya",LastName = "Kumar",Branch = "CSE",Age=23},
                new Student{ID= 108,FirstName = "Manoj",LastName = "Kumar",Branch = "ETC",Age=33 },
                new Student{ID= 109,FirstName = "Pranaya",LastName = "Rout",Branch = "ETC",Age=34},
                new Student{ID= 110,FirstName = "Saurav",LastName = "Rout",Branch = "CSE",Age=23}
            };

            var res2 = from s in listStudents select s;

            var res3 = from s1 in listStudents
                       select new Student
                       {
                           FirstName = s1.FirstName,
                           Branch = s1.Branch
                       };

            var res4 = from s1 in listStudents where s1.ID == 101 && s1.FirstName == "Preety" select s1;

            var res5 = from s1 in listStudents where s1.Age <= 35 select s1;

            var res6 = (from s in listStudents select s).Count();  // number not a coll



            int[] arr1 = { 354, 55, 354, 55, 45, 6, 6, 6, 6, 354, 55, 45, 6, 76, 77, 8, 9, 89, 90, 45, 56, 7, 67, 8, 787, 898, 9 };
            var c = (from s in arr1 select s).Count();
            var m = (from s in arr1 select s).MaxBy(x => x < 50);
            var min = (from s in arr1 select s).Min();
            var sum = (from s in arr1 select s).Sum();
            var avg = (from s in arr1 select s).Average();
            var dis = (from s in listStudents select s).DistinctBy(x => x.Age);
            //Console.WriteLine(m);

            var maxval = (from s in listStudents select s).Max(x => x.Age);
            //   Console.WriteLine(maxval);

            var maxval1 = (from s in listStudents select s).MaxBy(x => x.Age);
            //  Console.WriteLine(maxval1.FirstName);
            //foreach (var item in maxval)
            //{
            //    Console.WriteLine($"ID id {item.ID} name is {item.FirstName} lastname is {item.LastName} Branch id {item.Branch} and age is {item.Age}");
            //}

            object[] obj = { 234, "Hi", 56.45, true, true, 34, 56, 68, "test" };

            var mydata = obj.OfType<bool>().ToList();


            foreach (var item in dis)
            {
                //  Console.WriteLine($"ID id {item.ID} name is {item.FirstName} lastname is {item.LastName} Branch id {item.Branch} and age is {item.Age}");
            }
            // except union concat ,, merging the result

            int[] arr2 = { 354, 55, 354, 55, 45, 6, 6, 6, 6, 354, 55, 45, 6, 76, 77, 8, 9, 89, 90, 45, 56, 7, 67, 8, 787, 898, 9 };

            int[] arr3 = { 354, 55, 354, 55, 45, 6, 6, 6, 6, 67, 789, 79, 8, 9, 89, 90, 45, 56, 7, 67, 8, 787, 898, 9 };


            var merge = arr2.Union(arr3); // remove duplicates
            var Concat = arr2.Concat(arr3); // all value
            var Except = arr2.Except(arr3); // unique frpm left 
            var Intersect = arr2.Intersect(arr3); // unique frpm left 
            foreach (var item in Intersect)
            {
                // Console.WriteLine(item);
            }


            var myr = listStudents.UnionBy(listStudents1, p => p.ID);
            foreach (var item in myr)
            {
                //  Console.WriteLine($"ID id {item.ID} name is {item.FirstName} lastname is {item.LastName} Branch id {item.Branch} and age is {item.Age}");
            }

            int[] arr4 = { 354, 55, 354, 55, 45, 6, 6, 6, 6, 67, 789, 79, 8, 9, 89, 90, 45, 56, 7, 67, 8, 787, 898, 9 };


            var allEx = (from s in arr4 select s).All(x => x > 1);  // t

            var anyex = (from s in arr4 select s).Any(x => x > 50);

            var containEx = (from s in arr4 select s).Contains(6777);
            //  Console.WriteLine(containEx);

            var nums = new List<int> { 2, 4, 6, 8 };

            bool allEven = nums.All(x => x % 2 == 0);  // true
                                                       // Console.WriteLine(allEven);



            int[] arr5 = { 43, 65, 4, 64, 65, 756, 767, 8, 67899 };


            // elementat = (from s in arr5 select s).ElementAt(3);  // 55  
            //var elementat1 = (from s in arr5 select s).ElementAtOrDefault(3000);  // deault value of int is 0     
            // Console.WriteLine(elementat);


            var first = (from s in arr5 select s).First();
            var firstordef = (from s in arr5 select s).FirstOrDefault();

            var first1 = (from s in arr5 select s).First(x => x < 50);
            var firstordef1 = (from s in arr5 select s).FirstOrDefault();

            var last = (from s in arr5 select s).Last();  // 8
            var lastordef = (from s in arr5 select s).LastOrDefault();

            // var single = (from s in arr5 select s).SingleOrDefault(x => x > 500);  // 

            //   Console.WriteLine(single);

            int[] arr6 = { 43, 65, 500, 4, 64, 65, 756, 767, 8, 67899 };
            var take = (from s in arr6 select s).Take(5);
            var skip = (from s in arr6 select s).Skip(5);

            var take1 = (from s in arr6 select s).TakeWhile(x => x > 50);
            var skip1 = (from s in arr6 select s).SkipWhile(x => x > 346);
            foreach (var item in skip1)
            {
                Console.WriteLine(item);
            }

        }

        public static void Orderby()
        {
            List<Student> listStudents = new List<Student>()
            {
                new Student{ID= 101,FirstName = "Preety",LastName = "Tiwary",Branch = "CSE",Age=35},
                new Student{ID= 102,FirstName = "Preety",LastName = "Agrawal",Branch = "ETC",Age=35},
                new Student{ID= 103,FirstName = "Priyanka",LastName = "Dewangan",Branch = "ETC",Age=46},
                new Student{ID= 104,FirstName = "Hina",LastName = "Sharma",Branch = "ETC",Age=45 },
                new Student{ID= 105,FirstName = "Anugrag",LastName = "Mohanty",Branch = "CSE",Age=45},
                new Student{ID= 106,FirstName = "Anurag",LastName = "Sharma",Branch = "CSE",Age=34},
                new Student{ID= 107,FirstName = "Pranaya",LastName = "Kumar",Branch = "CSE",Age=23},
                new Student{ID= 108,FirstName = "Manoj",LastName = "Kumar",Branch = "ETC",Age=33 },
                new Student{ID= 109,FirstName = "Pranaya",LastName = "Rout",Branch = "ETC",Age=34},
                new Student{ID= 110,FirstName = "Saurav",LastName = "Rout",Branch = "CSE",Age=23}
            };

            var orderby = from s in listStudents orderby s.FirstName descending select s;
            var thenby = listStudents.OrderBy(x => x.FirstName)
                .ThenByDescending(x => x.LastName);
            foreach (var item in thenby)
            {
                //  Console.WriteLine($"ID id {item.ID} name is {item.FirstName} lastname is {item.LastName} Branch id {item.Branch} and age is {item.Age}");
            }


            var whereex = from s in listStudents
                          where s.Age > 30
                          orderby s.FirstName
                          select s; // 9 stu



            var countEx = (from s in listStudents
                           where s.Age > 30
                           orderby s.FirstName
                           select s).Count();  // 8  // stared & end



            var groupby = from s in listStudents group s by s.Branch;
            var lookup = listStudents.ToLookup(x => x.Branch);

            listStudents.Add(new Student
            {
                ID = 109,
                FirstName = "xyz",
                LastName = "Rout",
                Branch = "ETC",
                Age = 34
            });

            listStudents.Add(new Student
            {
                ID = 110,
                FirstName = "abc",
                LastName = "Rout",
                Branch = "CSE",
                Age = 23
            });
            //foreach (var item in whereex)
            //{
            //    Console.WriteLine($"ID id {item.ID} name is {item.FirstName} lastname is {item.LastName} Branch id {item.Branch} and age is {item.Age}");
            //}

            //Console.WriteLine(countEx);

            foreach (var item in groupby)
            {
                Console.WriteLine(item.Key);
                foreach (var item1 in item)
                {
                    Console.WriteLine($"ID id {item1.ID} name is {item1.FirstName} lastname is {item1.LastName} Branch id {item1.Branch} and age is {item1.Age}");

                }
            }
            Console.WriteLine("Lookup");
            
            foreach (var item in lookup)
            {
                Console.WriteLine(item.Key);
                foreach (var item1 in item)
                {
                    Console.WriteLine($"ID id {item1.ID} name is {item1.FirstName} lastname is {item1.LastName} Branch id {item1.Branch} and age is {item1.Age}");

                }
            }
        }
    }
}
