#region

using System.Collections.Generic;
using System.Linq;
using Common;

#endregion

namespace _08过滤器.Criteria
{
    internal class CriteriaMale : ICriteria
    {
        public IList<Person> MeetCriteria(IList<Person> persons)
        {
            return persons.Where(person => person.Gender.IsEqual("MALE")).ToList();
        }
    }
}