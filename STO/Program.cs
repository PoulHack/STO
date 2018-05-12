using STO.ORM;
using STO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.Entity.Infrastructure.MappingViews;

namespace STO
{
    class Program
    {
        public static void Main(string[] args)
        {
            Test testModelGenerator = new Test();
            Sto network1 = testModelGenerator.generate();
            
            STOOrm.Save(network1);

            Sto network2 = STOOrm.Restore();

            compareNetworks(network1, network2);
        }

        private static void compareNetworks(Sto network1, Sto network2)
        {
            StringWriter writer1 = new StringWriter(new StringBuilder());
            var reportGenerator1 = new Report(writer1, network1);
            reportGenerator1.generate();

            StringWriter writer2 = new StringWriter(new StringBuilder());
            var reportGenerator2 = new Report(writer2, network2);
            reportGenerator2.generate();

            String report1Content = writer1.ToString();
            String report2Content = writer2.ToString();

            Console.WriteLine(report1Content);
            Console.WriteLine(report2Content);
            Console.WriteLine(report1Content.Equals(report2Content) ? "PASSED: Models match" : "FAILED: Models mismatch");
            Console.ReadKey();
            //DbMappingViewCache mv = new DbMappingViewCache);
            //Console.WriteLine(mv.GetView("CodeFirstDatabase.Account"));
        }
    }
}
