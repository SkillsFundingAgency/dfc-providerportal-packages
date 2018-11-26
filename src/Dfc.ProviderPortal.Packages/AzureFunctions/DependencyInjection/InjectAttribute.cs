using Microsoft.Azure.WebJobs.Description;
using System;

namespace Dfc.ProviderPortal.Packages.AzureFunctions.DependencyInjection
{
    [Binding]
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public class InjectAttribute : Attribute
    {
    }
}