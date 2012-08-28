using System;
using NServiceBus;
using SampleCorpSystem.Contract.Sales;


namespace SampleCorpSystem.BillingProcessingApp.Billing
{
	public partial class OrderAcceptedProcessor
	{
		
        partial void HandleImplementation(OrderAccepted message)
        {
            // Implement your handler logic here.
            Console.WriteLine("OrderAccepted event received " + message.GetType().Name);
        }

	}
}