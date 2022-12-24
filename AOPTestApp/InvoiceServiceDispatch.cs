using System;
using System.Reflection;

namespace AOPTestApp
{
	public class InvoiceServiceDispatch<T> : DispatchProxy
        where T : class
	{
		public T Target { get; set; }

        public static T Create<T>(T target) where T : class
        {
            var proxy = Create<T, InvoiceServiceDispatch<T>>() as InvoiceServiceDispatch<T>;
            proxy.Target = target;
            return proxy as T;
        }

        protected override object? Invoke(MethodInfo? targetMethod, object?[]? args)
        {
            Console.WriteLine("Inside Proxy");
            //call original method
            return targetMethod.Invoke(Target, args);
        }
    }
}

