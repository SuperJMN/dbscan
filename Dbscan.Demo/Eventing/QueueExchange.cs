﻿using System.Collections.Concurrent;

namespace Dbscan.Demo.Eventing
{
    /// <summary>
    /// Example for an exchange
    /// </summary>
    /// <typeparam name="TQ"></typeparam>
    public class QueueExchange<TQ>
    {
        public QueueExchange()
        {
            Queue = new ConcurrentQueue<TQ>();
        }

        public ConcurrentQueue<TQ> Queue { get; private set; }
    }
}
