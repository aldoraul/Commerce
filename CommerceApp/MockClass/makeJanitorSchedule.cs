using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommerceApp.MockClass
{
    public class makeJanitorSchedule
    {
        public IList<JanitorSchedule> GetJanitorSchedule()
        {
            var list = new List<JanitorSchedule>();

            list.Add
                (
                    new JanitorSchedule
                    {
                        ID = 1,
                        Title = String.Format("Toilet Duty"),
                        IsAllDayEvent = true,
                        Start = DateTime.Now.AddDays(0).AddHours(0),
                        End = DateTime.Now.AddDays(6).AddHours(0),
                        color = String.Format("blue")
                    }

                    );
            return list;
        }
    }
}