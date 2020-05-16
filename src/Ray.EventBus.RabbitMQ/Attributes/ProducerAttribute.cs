﻿using System;

namespace Ray.EventBus.RabbitMQ
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ProducerAttribute : Attribute
    {
        public ProducerAttribute(string exchange = null, string routePrefix = null, int lBCount = 1, bool autoAck = false, bool persistent = false, int retryCount = 3, int retryIntervals = 500)
        {
            Exchange = exchange;
            RoutePrefix = routePrefix;
            LBCount = lBCount;
            AutoAck = autoAck;
            Persistent = persistent;
            RetryCount = retryCount;
            RetryIntervals = retryIntervals;
        }
        public string Exchange { get; }
        public string RoutePrefix { get; }
        public int LBCount { get; }
        public bool AutoAck { get; set; }
        public bool Persistent { get; set; }
        /// <summary>
        /// 发生异常重试次数
        /// </summary>
        public int RetryCount { get; set; }
        /// <summary>
        /// 重试间隔(ms)
        /// </summary>
        public int RetryIntervals { get; set; }
    }
}
