using System;

namespace WindowsServiceTeste.Service.Domain
{
    public partial class ControleWinServices
    {
        public string NmServico { get; set; }
        public string NmMaquina { get; set; }
        public DateTimeOffset DtUltimaExecucao { get; set; }
    }
}
