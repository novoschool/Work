using Calculator.Wcf.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Wcf
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static void Main()
        {
            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[]
            //{
            //    new CalculatorService()
            //};
            //ServiceBase.Run(ServicesToRun);
            var host = new ServiceHost(typeof(CalculatorService));
            try
            {
                host.Open();
                Console.WriteLine("The service is ready.");

                // Close the ServiceHost to stop the service.
                Console.WriteLine("Press <Enter> to terminate the service.");
                Console.WriteLine();
                Console.ReadLine();
                host.Close();
            }
            catch (CommunicationException ex) 
            {
                Console.WriteLine("An exception occurred: {0}", ex.Message);
                host.Abort();
            }
        }
    }
}
