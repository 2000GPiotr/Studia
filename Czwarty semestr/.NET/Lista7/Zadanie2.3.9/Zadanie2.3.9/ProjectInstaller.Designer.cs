
namespace Zadanie2._3._9
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ppw = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstaller1 = new System.ServiceProcess.ServiceInstaller();
            // 
            // ppw
            // 
            this.ppw.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.ppw.Password = null;
            this.ppw.Username = null;
            // 
            // serviceInstaller1
            // 
            this.serviceInstaller1.ServiceName = "Service1";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.ppw,
            this.serviceInstaller1});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller ppw;
        private System.ServiceProcess.ServiceInstaller serviceInstaller1;
    }
}