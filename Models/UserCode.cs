﻿using trnsACT.Data.Abstractions;
using System;

namespace trnsACT.Manage.Data.Models
{
    public partial class UserCode : IUserCode
    {
        public int Id { get; set; }     
        public int UserId { get; set; }   
        public string Code { get; set; }
        public string Action { get; set; }
        public string Value { get; set; }
        public DateTimeOffset Expiry { get; set; }
        public DateTimeOffset? RedeemedDate { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public byte[] RowVer { get; set; }
        public virtual AppUser User { get; set; }
    }
}
