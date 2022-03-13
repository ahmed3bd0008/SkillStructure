using System;
using System.Collections.Generic;
using Entity.Shared;

namespace Entity.Core
{
    public class RoomType : EntityId
    {
        public string RoomTypeName { get; set; }
        public ICollection<RatePerRoom> RatePerRooms { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}