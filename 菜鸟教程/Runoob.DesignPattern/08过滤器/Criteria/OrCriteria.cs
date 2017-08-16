#region

using System.Collections.Generic;
using System.Linq;

#endregion

namespace _08过滤器.Criteria
{
    internal class OrCriteria : ICriteria
    {
        private readonly ICriteria _criteria;
        private readonly ICriteria _otherCriteria;

        public OrCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            _criteria = criteria;
            _otherCriteria = otherCriteria;
        }

        public IList<Person> MeetCriteria(IList<Person> persons)
        {
            var firstCriteriaItems = _criteria.MeetCriteria(persons);
            var otherCriteriaItems = _otherCriteria.MeetCriteria(persons);

            return firstCriteriaItems.Union(otherCriteriaItems).ToList();
        }
    }
}