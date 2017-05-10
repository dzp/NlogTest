using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NLog;

namespace TestNlog
{
    class Program
    {
        static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Info("hello!");
            while (true)
            {

                logger.Info("hello!");
                Thread.Sleep(100);
            }

            return;
        }
    }
}
