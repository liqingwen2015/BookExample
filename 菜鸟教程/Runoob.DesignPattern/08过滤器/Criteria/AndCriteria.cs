#region

using System.Collections.Generic;

#endregion

namespace _08过滤器.Criteria
{
    internal class AndCriteria : ICriteria
    {
        private readonly ICriteria _criteria;
        private readonly ICriteria _otherCriteria;

        public AndCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            _criteria = criteria;
            _otherCriteria = otherCriteria;
        }

        public IList<Person> MeetCriteria(IList<Person> persons)
        {
            var firstCriteriaPersons = _criteria.MeetCriteria(persons);

            return _otherCriteria.MeetCriteria(firstCriteriaPersons);
        }
    }
}