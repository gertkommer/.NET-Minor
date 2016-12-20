﻿using System;

namespace Common.Event
{
    public class GameRoomEventMock : DomainEvent
    {
        public GameRoomEventMock(string routingKey) : base(routingKey)
        {

        }

        public int GameRoomId { get; set; }
        public string GameRoomName { get; set; }
    }
}