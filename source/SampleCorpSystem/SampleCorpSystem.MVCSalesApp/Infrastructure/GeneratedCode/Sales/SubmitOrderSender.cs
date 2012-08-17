using System;
using NServiceBus;
using NServiceBus.Config;
using SampleCorpSystem.InternalMessages.Sales;

namespace SampleCorpSystem.MVCSalesApp.Components.Sales
{
    public partial class SubmitOrderSender: ISubmitOrderSender, SampleCorpSystem.MVCSalesApp.Infrastructure.INServiceBusComponent
    {
        public void Send(SubmitOrder message)
		{
			Bus.Send(message);	
		}

        public IBus Bus { get; set; }
    }

    public interface ISubmitOrderSender
    {
        void Send(SubmitOrder message);
    }
}