using System;

namespace PersonUI
{
    public class ExitApplication : IExitApplication
    {
        public void ExitTheApp()
        {
            Environment.Exit(1);
        }
    }
}
