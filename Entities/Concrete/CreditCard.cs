using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CreditCard:IEntity
    {
        public int CardId { get; set; }
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public byte ExpirationMonth { get; set; }
        public byte ExpirationYear { get; set; }
        public string CVC { get; set; }
    }
}
