using System;
using Entity.Shared;

namespace Entity.Core
{
    public class RatePerRoom 
    {
       public DateTime From { get; set; }
       public DateTime To { get; set; }
       public Guid RoomTypeId{get;set;}
       public RoomType RoomType{get;set;}
       
    }
}