﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using Home.Domain.Abstract;
using Home.Domain.Concrete;

namespace Home.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IGeneralRepository>().To<EFGeneralRepository>();
            kernel.Bind<IArticleRepository>().To<EFArticleRepository>();
        }
    }
}