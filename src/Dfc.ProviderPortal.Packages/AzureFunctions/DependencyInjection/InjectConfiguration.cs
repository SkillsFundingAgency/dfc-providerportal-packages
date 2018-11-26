﻿using Microsoft.Azure.WebJobs.Host.Config;

namespace Dfc.ProviderPortal.Packages.AzureFunctions.DependencyInjection
{
    internal class InjectConfiguration : IExtensionConfigProvider
    {
        private readonly IInjectBindingProvider _injectBindingProvider;

        public InjectConfiguration(IInjectBindingProvider injectBindingProvider)
        {
            _injectBindingProvider = injectBindingProvider;
        }

        public void Initialize(ExtensionConfigContext context)
        {
            var rule = context
                .AddBindingRule<InjectAttribute>()
                .Bind(_injectBindingProvider);
        }
    }
}