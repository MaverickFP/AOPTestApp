using System;
namespace AOPTestApp
{
	public class InvoiceService : IInvoiceService
	{
		public InvoiceService()
		{
		}

		public void addInvoice()
		{
            Console.WriteLine("Add Invoice - from service!");
        }
	}
}

