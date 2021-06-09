using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
