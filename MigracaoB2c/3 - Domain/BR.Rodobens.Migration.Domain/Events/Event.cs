﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BR.Rodobens.Migration.Domain.Events
{
    public abstract class Event : Message, INotification
    {
        public DateTime Timestamp { get; private set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
