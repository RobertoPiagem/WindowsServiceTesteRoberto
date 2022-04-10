
namespace WindowsServiceTeste
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstallerTeste = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstallerTeste = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstallerTeste
            // 
            this.serviceProcessInstallerTeste.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstallerTeste.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceInstallerTeste});
            this.serviceProcessInstallerTeste.Password = null;
            this.serviceProcessInstallerTeste.Username = null;
            // 
            // serviceInstallerTeste
            // 
            this.serviceInstallerTeste.Description = "Teste Windows Service Roberto";
            this.serviceInstallerTeste.DisplayName = "Teste Windows Service Roberto";
            this.serviceInstallerTeste.ServiceName = "ServiceTeste";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstallerTeste});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstallerTeste;
        private System.ServiceProcess.ServiceInstaller serviceInstallerTeste;
    }
}