using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
    class Employee
    {
        public int EmplyeeID;
        public string FirstNam;
        public string LastName;
        public string Title;
        public Date DOB;
        public Date DOJ;
        public string City;
    }
    class LinqtoObjects
    {
        static void Main()
        {


            List<Employee> emplist = new List<Employee>()
            {
                new Employee(){EmplyeeID=1001,FirstNam="Malcolm",LastName= "Daruwalla" , Title= "Manager    ", DOB = Date.Parse( "16/11/1984"), DOJ =Date.Parse( " 8/ 6/2011"), City = "Mumbai"},
                new Employee(){EmplyeeID=1002,FirstNam="Asdin  ",LastName= "Dhalla   " , Title= "AsstManager", DOB = Date.Parse( "20/08/1984"), DOJ =Date.Parse( " 7/ 7/2012"), City = "Mumbai"},
                new Employee(){EmplyeeID=1003,FirstNam="Madhavi",LastName= "Oza      " , Title= "Consultant ", DOB = Date.Parse( "14/11/1987"), DOJ =Date.Parse( "12/ 4/2015"), City = "Pune"},
                new Employee(){EmplyeeID=1004,FirstNam="Saba   ",LastName= "Shaikh   " , Title= "SE         ", DOB = Date.Parse( " 3/ 6/1990"), DOJ =Date.Parse( " 2/ 2/2016"), City = "Pune"},
                new Employee(){EmplyeeID=1005,FirstNam="Nazia  ",LastName= "Shaikh   " , Title= "SE         ", DOB = Date.Parse( " 8/ 3/1991"), DOJ =Date.Parse( " 2/ 2/2016"), City = "Mumbai"},
                new Employee(){EmplyeeID=1006,FirstNam="Amit   ",LastName= "Pathak   " , Title= "Consultant ", DOB = Date.Parse( " 7/11/1989"), DOJ =Date.Parse( " 8/ 8/2014"), City = "Chennai"},
                new Employee(){EmplyeeID=1007,FirstNam="Vijay  ",LastName= "Natrajan " , Title= "Consultant ", DOB = Date.Parse( " 2/12/1989"), DOJ =Date.Parse( " 1/ 6/2015"), City = "Mumbai"},
                new Employee(){EmplyeeID=1008,FirstNam="Rahul  ",LastName= "Dubey    " , Title= "Associate  ", DOB = Date.Parse( "11/11/1993"), DOJ =Date.Parse( " 6/11/2014"), City = "Chennai"},
                new Employee(){EmplyeeID=1009,FirstNam="Suresh ",LastName= "Mistry   " , Title= "Associate  ", DOB = Date.Parse( "12/ 8/1992"), DOJ =Date.Parse( " 3/12/2014"), City = "Chennai"},
                new Employee(){EmplyeeID=1010,FirstNam="Sumit  ",LastName= "Shah     " , Title= "Manager    ", DOB = Date.Parse( "12/ 4/1991"), DOJ =Date.Parse( " 2/ 1/2016"), City = "Pune"},


            };
            Console.WriteLine("");
            Console.WriteLine("1. Display detail of all the employee");

            foreach (var i in emplist)
            {
                Console.WriteLine($"{i.EmplyeeID}   {i.FirstNam}   {i.LastName}   {i.Title}   {i.DOB}   {i.DOJ}   {i.City}");

            }


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("2. the employee whose location is not Mumbai: ");
            Console.WriteLine("");
            var result = from s in emplist
                         where !(!(s.City is "Pune") && !(s.City is "Chennai"))
                         select s;
            foreach (var i in result)
            {
                Console.WriteLine($"{i.EmplyeeID}   {i.FirstNam}   {i.LastName}   {i.Title}   {i.DOB}   {i.DOJ}   {i.City}");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("3.the employee whose title is AsstManager: ");
            var ti = from s in emplist
                     where s.Title is "AsstManager"
                     select s;
            foreach (var i in ti)
            {
                Console.WriteLine($"{i.EmplyeeID}   {i.FirstNam}   {i.LastName}   {i.Title}   {i.DOB}   {i.DOJ}   {i.City}");

            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("4.the employee whose Last Name start with S:");
            var ln = from s in emplist
                     where s.LastName.StartsWith("S")
                     select s.LastName;
            foreach (var s in ln)
            {
                Console.WriteLine(s);

            }


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("5.the employee who have joined before 1/1/2015 :");
            var dj = from s in emplist
                     where s.DOJ < Date.Parse("1/1/2015")
                     select s;
            foreach (var i in dj)
            {
                Console.WriteLine($"{i.EmplyeeID}   {i.FirstNam}   {i.LastName}   {i.Title}   {i.DOB}   {i.DOJ}   {i.City}");

            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("6.the employee whose date of birth is after 1/1/1990 :");
            var db = from s in emplist
                     where s.DOB > Date.Parse("1/1/1990")
                     select s;
            foreach (var i in db)
            {
                Console.WriteLine($"{i.EmplyeeID}   {i.FirstNam}   {i.LastName}   {i.Title}   {i.DOB}   {i.DOJ}   {i.City}");

            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("7.the employee whose designation is Consultant and Associate :");
            var de = from s in emplist
                     where !(!(s.Title is "Consultant ") && !(s.Title is "Associate  "))
                     select s;
            foreach (var i in de)
            {
                Console.WriteLine($"{i.EmplyeeID}   {i.FirstNam}   {i.LastName}   {i.Title}   {i.DOB}   {i.DOJ}   {i.City}");

            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("8.Display total number of employees :");
            var to = emplist.Count();
            Console.WriteLine(to);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("9. Display total number of employees belonging to “Chennai” : ");
            var tot = from s in emplist
                      where s.City is "Chennai"
                      select s;
            var tott = tot.Count();
            Console.WriteLine(tott);


            // From Here iam Using Linq Method Syntax

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("10. Display highest employee id from the list :");
            var res1 = emplist.Max(a => a.EmplyeeID);
            Console.WriteLine("{0}", res1);


            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("11. Display  total number of employee who have joined after 1/1/2015 : ");
            var dooj = emplist.Where(d => d.DOJ > Date.Parse(" 1/ 1/2015")).Count<Employee>();
            Console.WriteLine(dooj);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("12. Display total number of employee whose designation is not “Associate” :");
            var tit = emplist.Where(d => d.Title == "Associate  ").Count<Employee>();
            Console.WriteLine(tit);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("13. Display total number of employee based on City: ");
            //var tote = emplist.Where(d => d.City == "Chennai" ).Count<Employee>();
            //Console.WriteLine("Chennai: "+ tote);
            //var tota = emplist.Where(d =>  d.City == "Mumbai" ).Count<Employee>();
            //Console.WriteLine("Mumbai: " +tota);
            //var total = emplist.Where(d =>  d.City == "Pune").Count<Employee>();
            //Console.WriteLine("Pune: "+total);

            var myquery13 = from p in emplist
                            group p by p.City into g
                            select new { City = g.Key, ProductCount = g.Count() };
            Console.WriteLine("City\t   No.of Employees");
            foreach (var group in myquery13)
            {
                Console.WriteLine(group.City + "\t\t" + group.ProductCount);
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("14. Display total number of employee based on city and title : ");
            //var t1 = emplist.Where(d => d.City == "Chennai" && d.Title == "Manager    " && d.Title == "AsstManager" && d.Title == "Consultant ").Count<Employee>();
            //Console.WriteLine("Chennai: " + t1);
            //var t2 = emplist.Where(d => d.City == "Mumbai").Count<Employee>();
            //Console.WriteLine("Mumbai: " + t2);
            //var t3 = emplist.Where(d => d.City == "Pune").Count<Employee>();
            //Console.WriteLine("Pune: " + t3);

            //var c1 = emplist.Where(d => d.Title == "Manager    ").Count<Employee>();
            //Console.WriteLine("Manager : " + c1);
            //var c2 = emplist.Where(d => d.Title == "AsstManager").Count<Employee>();
            //Console.WriteLine("AsstManager: " + c2);
            //var c3 = emplist.Where(d => d.Title == "Consultant " ).Count<Employee>();
            //Console.WriteLine("Consultant: " + c3);
            //var c4 = emplist.Where(d => d.Title == "SE         ").Count<Employee>();
            //Console.WriteLine("SE : " + c4);
            //var c5 = emplist.Where(d => d.Title == "Consultant ").Count<Employee>();
            //Console.WriteLine("Associate  " + c5);
            var myquery14 = from t in emplist
                            group t by t.Title into g
                            select new { Title = g.Key, ProductCount = g.Count() };
            Console.WriteLine("Ttile\t   No.of Employees");
            foreach (var group in myquery14)
            {
                Console.WriteLine(group.Title + "\t\t" + group.ProductCount);
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("15. Display total number of employee who is youngest in the list :");
            var yo = emplist.Max(x => x.DOB);
            var you = emplist.Where(x => x.DOB == yo);

            foreach (var item in you)
            {
                Console.WriteLine("The youngest Employee Of All the Employees is : {0} {1}", item.FirstNam, item.LastName);
            }





            Console.ReadKey();

        }
    }

}
--------------------------------------------------------------------------------------------------
Outputs:--

1.Display detail of all the employee
1001   Malcolm   Daruwalla   Manager       1984-11-16   2011-06-08   Mumbai
1002   Asdin     Dhalla      AsstManager   1984-08-20   2012-07-07   Mumbai
1003   Madhavi   Oza         Consultant    1987-11-14   2015-04-12   Pune
1004   Saba      Shaikh      SE            1990-06-03   2016-02-02   Pune
1005   Nazia     Shaikh      SE            1991-03-08   2016-02-02   Mumbai
1006   Amit      Pathak      Consultant    1989-11-07   2014-08-08   Chennai
1007   Vijay     Natrajan    Consultant    1989-12-02   2015-06-01   Mumbai
1008   Rahul     Dubey       Associate     1993-11-11   2014-11-06   Chennai
1009   Suresh    Mistry      Associate     1992-08-12   2014-12-03   Chennai
1010   Sumit     Shah        Manager       1991-04-12   2016-01-02   Pune


2. the employee whose location is not Mumbai:

1003   Madhavi Oza         Consultant    1987-11-14   2015-04-12   Pune
1004   Saba      Shaikh      SE            1990-06-03   2016-02-02   Pune
1006   Amit      Pathak      Consultant    1989-11-07   2014-08-08   Chennai
1008   Rahul     Dubey       Associate     1993-11-11   2014-11-06   Chennai
1009   Suresh    Mistry      Associate     1992-08-12   2014-12-03   Chennai
1010   Sumit     Shah        Manager       1991-04-12   2016-01-02   Pune


3.the employee whose title is AsstManager:
1002   Asdin Dhalla      AsstManager   1984-08-20   2012-07-07   Mumbai


4.the employee whose Last Name start with S:
Shaikh
Shaikh
Shah


5.the employee who have joined before 1/1/2015 :
1001   Malcolm Daruwalla   Manager       1984-11-16   2011-06-08   Mumbai
1002   Asdin     Dhalla      AsstManager   1984-08-20   2012-07-07   Mumbai
1006   Amit      Pathak      Consultant    1989-11-07   2014-08-08   Chennai
1008   Rahul     Dubey       Associate     1993-11-11   2014-11-06   Chennai
1009   Suresh    Mistry      Associate     1992-08-12   2014-12-03   Chennai


6.the employee whose date of birth is after 1/1/1990 :
1004   Saba Shaikh      SE            1990-06-03   2016-02-02   Pune
1005   Nazia     Shaikh      SE            1991-03-08   2016-02-02   Mumbai
1008   Rahul     Dubey       Associate     1993-11-11   2014-11-06   Chennai
1009   Suresh    Mistry      Associate     1992-08-12   2014-12-03   Chennai
1010   Sumit     Shah        Manager       1991-04-12   2016-01-02   Pune


7.the employee whose designation is Consultant and Associate :
1003   Madhavi Oza         Consultant    1987-11-14   2015-04-12   Pune
1006   Amit      Pathak      Consultant    1989-11-07   2014-08-08   Chennai
1007   Vijay     Natrajan    Consultant    1989-12-02   2015-06-01   Mumbai
1008   Rahul     Dubey       Associate     1993-11-11   2014-11-06   Chennai
1009   Suresh    Mistry      Associate     1992-08-12   2014-12-03   Chennai


8.Display total number of employees :
10


9.Display total number of employees belonging to "Chennai" : 3


10.Display highest employee id from the list :1010


11.Display  total number of employee who have joined after 1/1/2015 : 5


12.Display total number of employee whose designation is not "Associate" :2


13.Display total number of employee based on City:
City No.of Employees
Mumbai          4
Pune            3
Chennai         3


14. Display total number of employee based on city and title :
Ttile No.of Employees
Manager                 2
AsstManager             1
Consultant              3
SE                      2
Associate               2


15. Display total number of employee who is youngest in the list :
The youngest Employee Of All the Employees is : Rahul Dubey

