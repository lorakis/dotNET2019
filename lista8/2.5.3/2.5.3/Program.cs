using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Linq;
using _2._5._2;
using System.Runtime.CompilerServices;

namespace _2._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SampleDataContext(@"server=DESKTOP-L7MABQF\SQLEXPRESS;database=_2._5._2;integrated security=true"))
            {
                var ouut = context.Student.Where(p => p.Name.StartsWith("Maria"));
                Student deel = ouut.FirstOrDefault();
                context.Student.DeleteOnSubmit(deel);
                Student neew = new Student();
                neew.Name = "Lidia";
                neew.Surname = "Moraw";
                City place = new City();
                place.Name = "Szczecin";
                neew.City = temp;
                neew.Birth = new DateTime(1999, 5, 28);
                context.Student.InsertOnSubmit(neew);
                var placeSwitch = context.Student.Where(p => p.Name.StartsWith("Marta"));
                Student dif = placeSwitch.FirstOrDefault();
                dif.City = context.City.Where(m => m.Name.StartsWith("Warszawa")).FirstOrDefault();
                context.SubmitChanges();
            }  
        }
    }
}
