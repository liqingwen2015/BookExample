#region

using System.Collections.Generic;

#endregion

namespace _08过滤器.Criteria
{
    internal interface ICriteria
    {
        IList<Person> MeetCriteria(IList<Person> persons);
    }
}