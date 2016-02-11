using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;
using System.Windows.Forms;
using Microsoft.Win32;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;

namespace Company.OpenConfigurationManager
{

    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(PackageGuids.guidOpenConfigurationManagerPkgString)]
    public sealed class OpenConfigurationManagerPackage : Package
    {
        public OpenConfigurationManagerPackage()
        {
            Debug.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering constructor for: {0}", this.ToString()));
        }



        #region Package Members

        protected override void Initialize()
        {
            Debug.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering Initialize() of: {0}", this.ToString()));
            base.Initialize();

            OleMenuCommandService mcs = GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            if (null != mcs)
            {
                CommandID menuCommandID = new CommandID(PackageGuids.guidOpenConfigurationManagerCmdSet, (int)PackageIds.cmdidMyCommand);
                MenuCommand menuItem = new MenuCommand(MenuItemCallback, menuCommandID);
                mcs.AddCommand(menuItem);
            }
        }
        #endregion

        private void MenuItemCallback(object sender, EventArgs e)
        {
            var configManager = GetService(typeof(SVsConfigurationManagerDlg)) as IVsConfigurationManagerDlg;
            var solutionService = GetService(typeof(SVsSolution)) as IVsSolution;
            object projectCount = null;
            if (solutionService != null)
            {
                solutionService.GetProperty((int)__VSPROPID.VSPROPID_ProjectCount, out projectCount);
            }
            if (projectCount != null && (int)projectCount <= 0)
            {
                MessageBox.Show("No projects are open!");
            }
            else if (configManager != null)
            {
                configManager.ShowConfigurationManagerDlg();
            }
        }

    }
}
