﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KC.Actin {
    public class ActorLog : IActinLogger {
        public void Log(ActinLog log) {
            log = log.WithNoNulls();
            //TODO: Store X number of logs...
        }
    }
}
