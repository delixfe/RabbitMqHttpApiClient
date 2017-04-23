﻿using Newtonsoft.Json;
using RabbitMqHttpApiClient.ConsoleApp.Models.Common;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.ChannelModel
{
    public class ConsumerDetail
    {
        [JsonProperty("arguments")]
        public Arguments Arguments { get; set; }

        [JsonProperty("prefetch_count")]
        public int PrefetchCount { get; set; }

        [JsonProperty("ack_required")]
        public bool AckRequired { get; set; }

        [JsonProperty("exclusive")]
        public bool Exclusive { get; set; }

        [JsonProperty("consumer_tag")]
        public string ConsumerTag { get; set; }

        [JsonProperty("queue")]
        public Queue Queue { get; set; }

        [JsonProperty("channel_details")]
        public ConsumerChannelDetails ChannelDetails { get; set; }
    }
}