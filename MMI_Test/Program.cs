using System;
using System.Security;
using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;

namespace MMI_Test
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Create a CimSession with the remote system
            CimSessionOptions options = new DComSessionOptions();
            //options.AddDestinationCredentials(cimCreds);
            CimSession session = CimSession.Create("localhost", options);

            // Create a CimMethodParametersCollection to pass to method invocation
            CimMethodParametersCollection collection = new CimMethodParametersCollection();
            collection.Add(CimMethodParameter.Create("CommandLine", "calc.exe", CimFlags.None));

            // Invoke the Win32_Process classes Create method to start a calc.exe process on a remote system
            CimMethodResult result = session.InvokeMethod("root/cimv2", "Win32_Process", "Create", collection);
            if (result.ReturnValue.ToString() == "0")
            {

            }
            else
            {

            }

            session.Dispose();
        }
    }
}