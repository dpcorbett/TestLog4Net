using SharpTools.Log;
using System;

namespace TestLog4Net
{
    class Program
    {
        //private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly log4net.ILog _log = SharpToolsLog.GetLogger();

        static void Main(string[] args)
        {
            _log.Debug("Developer: Tutorial was run");
            _log.Info("Maintenance: water pump turned on");
            _log.Warn("Maintenance: the water pump is getting hot");

            var i = 0;

            try
            {
                var x = 10 / i;
            }
            catch (DivideByZeroException exc)
            {
                _log.Error("Developer: we tried to divide by zero again", exc);
            }

            _log.Fatal("Maintenance: water pump exploded");

            Console.ReadLine();
        }
    }
}
