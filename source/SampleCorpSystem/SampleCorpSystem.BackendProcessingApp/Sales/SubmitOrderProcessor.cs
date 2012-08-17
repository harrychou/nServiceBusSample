using System;
using NServiceBus;
using SampleCorpSystem.InternalMessages.Sales;


namespace SampleCorpSystem.BackendProcessingApp.Sales
{
	public partial class SubmitOrderProcessor
	{
		
        partial void HandleImplementation(SubmitOrder message)
        {
            // Implement your handler logic here.
            Console.WriteLine("Sales received " + message.GetType().Name);
        }

	}
}