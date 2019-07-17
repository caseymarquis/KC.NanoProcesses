﻿using KC.Actin.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace KC.Actin
{
    public class ActorUtil
    {
        public DateTimeOffset Now { get; set; }
        public IActinLogger Log { get; set; } = new EmptyNpLogger();
    }
}