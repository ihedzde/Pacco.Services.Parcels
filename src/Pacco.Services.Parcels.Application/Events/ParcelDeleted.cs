using System;
using Convey.CQRS.Events;

namespace Pacco.Services.Parcels.Application.Events
{
    public class ParcelDeleted : IEvent
    {
        public Guid Id { get; }
        
        public ParcelDeleted(Guid id)
        {
            Id = id;
        }
    }
}