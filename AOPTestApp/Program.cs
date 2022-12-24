// See https://aka.ms/new-console-template for more information
using AOPTestApp;

Console.WriteLine("--- Use of DispatchProxy ---");

IInvoiceService invoiceService = new InvoiceService();
invoiceService = InvoiceServiceDispatch<IInvoiceService>.Create(invoiceService);
invoiceService.addInvoice();

