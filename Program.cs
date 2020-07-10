using System;
using System.Linq;

namespace PluginDemo
{
   

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Currently available features:");
            foreach (var feature in FeatureManager.Features)
            {
                Console.WriteLine(feature.Description);
            }

            var addition = FeatureManager.Features.FirstOrDefault(f => f.Description == "Addition");
            if (addition != null)
            {
                Console.WriteLine("1 + 2 = " + addition.Execute(1,2) );
            }

            var subtraction = FeatureManager.Features.FirstOrDefault(f => f.Description == "Subtraction");
            if (subtraction != null)
            {
                Console.WriteLine("1 - 2 = " + subtraction.Execute(1, 2));
            }

        }
    }
}
