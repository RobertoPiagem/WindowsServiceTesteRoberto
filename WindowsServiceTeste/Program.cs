using System.ServiceProcess;
using WindowsServiceTeste.Service.Data;

namespace WindowsServiceTeste
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        static void Main()
        { 
            var iRepository = new ControleWinServicesRepository();

            /// Para testar em ambiente local
            
            //#if DEBUG
            //var serviceTeste = new ServiceTeste(iRepository);
            //    serviceTeste.OnDebug();
            //#else
                ServiceBase[] ServicesToRun;

                ServicesToRun = new ServiceBase[]
                {
                    new ServiceTeste(iRepository)
                };
                ServiceBase.Run(ServicesToRun);
            //#endif
        }
    }
}