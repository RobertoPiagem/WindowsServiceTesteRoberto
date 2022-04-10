using System;
using System.ServiceProcess;
using System.Threading;
using WindowsServiceTeste.Service.Domain.ControleWinServicesRoot.Interface;

namespace WindowsServiceTeste
{
    public partial class ServiceTeste : ServiceBase
    {
        private IControleWinServicesRepository _iRepository { get; }

        public ServiceTeste(IControleWinServicesRepository iRepository)
        {
            InitializeComponent();
            _iRepository = iRepository;
        }

        public void OnDebug()
        {
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                _iRepository.Inserir("Serviço 'Windows Service Teste - Roberto' iniciado com sucesso !");
                Thread.Sleep(60000);                
            }
            catch (Exception ex)
            {
                _iRepository.Inserir("Erro ao executar o Serviço 'Windows Service Teste - Roberto' Tipo do Erro: " + ex.Message);
            }            
        }

        protected override void OnStop()
        {
            try
            {
                _iRepository.Inserir("Serviço 'Windows Service Teste - Roberto' parado com sucesso !");
                Thread.Sleep(60000);
            }
            catch (Exception ex)
            {
                _iRepository.Inserir("Erro ao executar o Serviço 'Windows Service Teste - Roberto' Tipo do Erro: " + ex.Message);
            }
        }

        protected override void OnPause()
        {
            try
            {
                _iRepository.Inserir("Serviço 'Windows Service Teste - Roberto' pausado com sucesso !");
                Thread.Sleep(60000);                
            }
            catch (Exception ex)
            {
                _iRepository.Inserir("Erro ao executar o Serviço 'Windows Service Teste - Roberto' Tipo do Erro: " + ex.Message);
            }
        } 
    }
}