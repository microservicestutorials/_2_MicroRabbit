using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    //in TEvent means TAKES IN ANY TYPE OF EVENT
    public interface IEventHandler<in TEvent> : IEventHandler where TEvent : Event
    { 
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    { }
}