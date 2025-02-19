﻿using Autofac;
using FriendOrganiser.UI.Startup;
using System.Windows;

namespace FriendOrganiser.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Bootstrapp();
            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }
    }
}
