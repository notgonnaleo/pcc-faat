﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Backend.Domain.Enums.EnumExtensions;

namespace Backend.Domain.Enums.Payments
{
    public enum PaymentsEnum
    {
        Pending = 1, 
        Declined = 2,
        Confirmed = 3, 
        Failed = 4,
        Refunded = 5,
    }

    public enum PaymentTypesEnum
    {
        [Description("Credit")]
        Credit = 1,
        [Description("Debit")]
        Debit = 2,
        [Description("Bank Slip")]
        BankSlip = 3,
        [Description("PIX")]
        PIX = 4,
    }
}
