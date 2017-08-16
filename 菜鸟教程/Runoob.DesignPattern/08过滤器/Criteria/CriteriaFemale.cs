#region

using System.Collections.Generic;
using System.Linq;
using Common;

#endregion

namespace _08过滤器.Criteria
{
    internal class CriteriaFemale : ICriteria
    {
        public IList<Person> MeetCriteria(IList<Person> persons)
        {
            return persons.Where(x => x.Gender.IsEqual("FEMALE")).ToList();
        }
    }
}