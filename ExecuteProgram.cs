using System;

namespace CodeInterview_Automation
{
    internal class ExecuteProgram
    {
        static void Main(string[] args)
        {
            GoogleFinance_UI googleFinance = new GoogleFinance_UI();
            googleFinance.StartExecution();

            REST_API_Test restapi = new REST_API_Test();
            restapi.TestResources();
        }
    }
}
