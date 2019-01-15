using CodingChallenge.Models;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.IServices
{
    public class CommonService: ICommonService
    {/// <summary>
     /// Takes List of list as input and provide the comparison result as output
     /// </summary>
     /// <param name="listsToCompare"></param>
     /// <returns>SortedCompareList</returns>
        public override ListCompareResult GetComparedList(ListsToCompare listsToCompare)
        {
            ListCompareResult comparisonResult = new ListCompareResult();
            if (listsToCompare != null && listsToCompare.Current != null && listsToCompare.Initial != null)
            {
                List<KeyValuePairs> initial = new List<KeyValuePairs>();
                List<KeyValuePairs> current = new List<KeyValuePairs>();

                initial = listsToCompare.Initial.Where(c => c != null).ToList(); // Assign valued to initial
                current = listsToCompare.Current.Where(c => c != null).ToList(); // Assign valued to Current

                List<KeyValuePairs> newList = GetNewList(initial, current); // get the newly added items comparing keys
                List<KeyValuePairs> deleteList = GetDeletedList(initial, current); // get the deleted items comparing keys
                List<KeyValuePairs> updatedList = GetUpdatedList(initial, current); // get the updated items comparing keys

                comparisonResult.NewItems = newList;
                comparisonResult.UpdatedItems = updatedList;
                comparisonResult.DeletedItems = deleteList;
                comparisonResult.Message = "Success";
            }
            else
            {
                comparisonResult.Message = "Please provide valid input.";
            }
            return comparisonResult;
        }

     
    }
}
