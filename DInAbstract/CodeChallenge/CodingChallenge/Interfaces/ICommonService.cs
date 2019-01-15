using CodingChallenge.Models;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.IServices
{
    public abstract class ICommonService
    {
        public abstract ListCompareResult GetComparedList(ListsToCompare listsToCompare);

        /// <summary>
        ///  Get a list of values that are both in “current” and “initial” but have a different value
        /// </summary>
        /// <param name="initial">Initial List</param>
        /// <param name="current"> Current List</param>
        /// <returns> List of updated values</returns>
        public List<KeyValuePairs> GetUpdatedList(List<KeyValuePairs> initial, List<KeyValuePairs> current)
        {
            List<KeyValuePairs> updatedList = current.Where(a => initial.Any(o => o.Key == a.Key && o.Value != a.Value)).ToList();
            return updatedList;
        }

        /// <summary>
        /// Get the list of keys – and their values --  that are in “current” but not in “initial”
        /// </summary>
        /// <param name="initial">Initial List</param>
        /// <param name="current"> Current List</param>
        /// <returns> List of deleted values</returns>
        public List<KeyValuePairs> GetDeletedList(List<KeyValuePairs> initial, List<KeyValuePairs> current)
        {
            List<KeyValuePairs> deleteList = initial.Where(a => !current.Any(o => o.Key == a.Key)).ToList();
            return deleteList;
        }

        /// <summary>
        /// Get the list of keys – and their values --  that are in “current” but not in “initial”
        /// </summary>
        /// <param name="initial">Initial List</param>
        /// <param name="current"> Current List</param>
        /// <returns> List of newly added values</returns>
        public List<KeyValuePairs> GetNewList(List<KeyValuePairs> initial, List<KeyValuePairs> current)
        {
            List<KeyValuePairs> newList = current.Where(a => !initial.Any(o => o.Key == a.Key)).ToList();
            return newList;
        }
    }

}
