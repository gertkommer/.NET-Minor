﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minor.RoWe.Common.Interfaces
{
    public interface IEventDispatcher : IDisposable
    {
        void StartListening();
        
    }
}
