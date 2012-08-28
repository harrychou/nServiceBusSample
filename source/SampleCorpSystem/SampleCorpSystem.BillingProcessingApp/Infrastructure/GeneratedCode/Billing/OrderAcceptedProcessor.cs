using System;
using NServiceBus;
using SampleCorpSystem.Contract.Sales;


namespace SampleCorpSystem.BillingProcessingApp.Billing
{
    public partial class OrderAcceptedProcessor : IHandleMessages<OrderAccepted>
    {
		
		public void Handle(OrderAccepted message)
		{
			this.HandleImplementation(message);
		}

		partial void HandleImplementation(OrderAccepted message);

		public IBus Bus { get; set; }

    }
}