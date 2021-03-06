﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLibrary.Core.Extentions
{
    public static class DateTimeExtentions
    {
        public static DateTime FirstDayOfWeek(this DateTime dt)
        {
            int diff = (7 + (dt.DayOfWeek - DayOfWeek.Monday))%7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}
