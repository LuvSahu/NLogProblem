using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogPratice
{
    public class Addition
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static void Sum(int first , int second)
        {
            if(first>0 && second>0)
            {
                int res = first+ second;
                logger.Debug("Debug successful with sum operation");
                logger.Info("Successfully completed and Sum is:" + res);
            }
            else
            {
                logger.Warn("Input should not be 0 or less than zero");
                logger.Error("Input should be +ve number");
            }
        }
    }
}
