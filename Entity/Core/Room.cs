using System;
using Entity.Shared;

namespace Entity.Core
{
    public class Room : EntityId
    {
        public string RoomName { get; set; }
        public Guid RoomTypeId{get;set;}
       public RoomType RoomType{get;set;}
    }
}