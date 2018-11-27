using Microsoft.Azure.WebJobs.Host.Bindings;
using System;
using System.Threading.Tasks;

namespace Dfc.ProviderPortal.Packages.AzureFunctions.DependencyInjection
{
    internal class InjectValueProvider : IValueProvider
    {
        private readonly object _value;

        public InjectValueProvider(object value)
        {
            _value = value;
        }

        public Type Type => _value.GetType();

        public Task<object> GetValueAsync() => Task.FromResult(_value);

        public string ToInvokeString() => _value.ToString();
    }
}