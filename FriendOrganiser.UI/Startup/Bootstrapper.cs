﻿using Autofac;
using FriendOrganiser.UI.Data;
using FriendOrganiser.UI.ViewModel;

namespace FriendOrganiser.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrapp()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<FriendDataService>().As<IFriendDataService>();

            return builder.Build();
        }
    }
}
