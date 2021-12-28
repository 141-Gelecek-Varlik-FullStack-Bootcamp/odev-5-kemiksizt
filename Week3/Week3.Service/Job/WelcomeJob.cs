using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Service.Job
{
    public class WelcomeJob : IWelcomeJob
    {

        public void PrintWelcome()
        {
            Console.WriteLine($"Hangfire recurring job");
        }

    }
}
