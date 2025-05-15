using System.Collections;
using System.ComponentModel;

namespace HtmlStringBuilder
{
    [RunInstaller(true)]
    public partial class AppInstaller : System.Configuration.Install.Installer
    {
        public AppInstaller()
        {
            InitializeComponent();
        }

        protected override void OnBeforeInstall(IDictionary savedState)
        {
            base.OnBeforeInstall(savedState);
        }

        public override void Install(IDictionary stateSaver)
        {

            stateSaver.Add("assemblypath", Context.Parameters["assemblypath"]);
            base.Install(stateSaver);
        }

        protected override void OnAfterInstall(IDictionary savedState)
        {
            base.OnAfterInstall(savedState);
        }

        public override void Rollback(IDictionary savedState)
        {
            base.Rollback(savedState);
        }

        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);
        }

        protected override void OnAfterUninstall(IDictionary savedState)
        {
            base.OnAfterUninstall(savedState);
        }

        protected override void OnCommitted(IDictionary savedState)
        {
            string dir = savedState["assemblypath"].ToString();
            base.OnCommitted(savedState);
        }
    }
}
