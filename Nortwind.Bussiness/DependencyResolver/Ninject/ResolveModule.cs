﻿using System;
using System.Configuration;
using Ninject;
using Ninject.Modules;
using Project.Root.DependencyResolver.Ninject;

namespace Project.Root.DependencyResolver.Ninject
{
    public class ResolveModule : NinjectModule
    {
        public override void Load()
        {
            var soaSetting = ConfigurationManager.AppSettings["SOA"];

            var soa = !string.IsNullOrEmpty(soaSetting) && Convert.ToBoolean(soaSetting);

            if (soa)
            {
                /*Kernel.Load(new ServiceModule())*/;
            }
            else
            {
                Kernel.Load(new BusinessModule());
            }
        }
    }
}