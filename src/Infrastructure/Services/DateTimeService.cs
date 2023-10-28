using SQAT5.Application.Common.Interfaces;

namespace SQAT5.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
