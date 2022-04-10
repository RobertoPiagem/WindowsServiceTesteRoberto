using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Net;
using WindowsServiceTeste.Service.Domain;
using WindowsServiceTeste.Service.Domain.ControleWinServicesRoot.Interface;

namespace WindowsServiceTeste.Service.Data
{
    public class ControleWinServicesRepository : IControleWinServicesRepository
    {
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "x9gLSbslGk7ls9eEJMYZpmVvixEd6rxfQZzMqdYc",
            BasePath = "https://teste---vaga-de-net-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public void Inserir(string nmServico)
        {
            try
            {
                var std = new ControleWinServices()
                {
                    NmServico = nmServico,
                    NmMaquina = Dns.GetHostEntry(Environment.MachineName).HostName,
                    DtUltimaExecucao = DateTimeOffset.Now
                };

                client = new FireSharp.FirebaseClient(fcon);

                var setter = client.Set("ControleWinServices/" + Guid.NewGuid(), std);

            }
            catch (Exception ex)
            {
                Inserir("Erro ao executar o Serviço 'Windows Service Teste - Roberto' Tipo do Erro: " + ex.Message);
            }
        }
    }
}