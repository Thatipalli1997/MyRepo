using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeEntryApiApplication
{
    public class TimeEntry
    {
        public long? Id { get; set; }
        public long ProjectId { get; set; }
        public long UserId { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }


        public TimeEntry(long id, long projectid, long userId, DateTime date, int hours)
        {
            Id = id;
            ProjectId = projectid;
            UserId = userId;
            Date = date;
            Hours = hours;

        }
        public TimeEntry(long projectid, long userid, DateTime date, int hours)
        {
            Id = null;
            ProjectId = projectid;
            UserId = userid;
            Date = date;
            Hours = hours;

        }

    }
}
