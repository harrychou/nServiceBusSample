using System;
using NServiceBus;
using SampleCorpSystem.InternalMessages.Sales;


namespace SampleCorpSystem.BackendProcessingApp.Sales
{
    public partial class SubmitOrderProcessor : IHandleMessages<SubmitOrder>
    {
		
		public void Handle(SubmitOrder message)
		{
			this.HandleImplementation(message);
		}

		partial void HandleImplementation(SubmitOrder message);

		public IBus Bus { get; set; }

    }
}