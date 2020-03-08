﻿// Copyright (c) Quarrel. All rights reserved.

using DiscordAPI.Models;

namespace Quarrel.ViewModels.Messages.Gateway.Channels
{
    public sealed class GatewayDirectMessageChannelCreatedMessage
    {
        public GatewayDirectMessageChannelCreatedMessage(DirectMessageChannel channel)
        {
            Channel = channel;
        }

        public DirectMessageChannel Channel { get; }
    }
}
