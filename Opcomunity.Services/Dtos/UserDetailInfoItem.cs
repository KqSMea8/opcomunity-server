﻿using Opcomunity.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcomunity.Services.Dtos
{
    public class UserDetailInfoItem
    {
        public Int64 UserId { get; set; }
        public string NickName { get; set; }
        public string Avatar { get; set; }
        public string ThumbnailAvatar { get; set; }
        public string Description { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public DateTime? Birthday { get; set; }
        public string Constellation { get; set; }
        public int AuthStatus { get; set; }
        public int CallRatio { get; set; }
        public bool IsFollow { get; set; }
        public int FollowCount { get; set; }
        public bool IsAnchor { get; set; }
        public long Glamour { get; set; }
        public string NeteaseAccId { get; set; } 
        public int NeteaseLoginStatus { get; set; }
        public int NeteaseChatStatus { get; set; }
        public bool IsVip { get; set; }
        public virtual IQueryable<UserPhotoItem> UserPhotoItems { get; set; }
    }
}
