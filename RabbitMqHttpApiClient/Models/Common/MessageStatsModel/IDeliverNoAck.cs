﻿using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.Common.MessageStatsModel
{
    public interface IDeliverNoAck
    {
        [JsonProperty("deliver_no_ack")]
        int DeliverNoAck { get; set; }

        [JsonProperty("deliver_no_ack_details")]
        RateDetails DeliverNoAckDetails { get; set; }
    }
}