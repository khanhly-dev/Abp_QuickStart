﻿using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.CardInfo.Dto
{
    [AutoMapTo(typeof(CardInfoEntity))]
    public class UpdateCardDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string District { get; set; }
    }
}
