﻿using Newtonsoft.Json;

namespace nerderies.TelegramBotApi.DTOS
{
    public class DeleteChatPhotoReply : Reply
    {
        [JsonProperty("ok")]
        public bool Ok;

        [JsonProperty("result")]
        public bool Success;
    }
}