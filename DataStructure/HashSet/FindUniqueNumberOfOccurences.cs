
namespace DataStructure.HashSet
{
    public class FindUniqueNumberOfOccurences
    {
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (dict.ContainsKey(item))
                    dict[item]++;
                else
                    dict.Add(item, 1);
            }

            var valueSet = new HashSet<int>(dict.Values);

            return valueSet.Count == dict.Count;

        }
    }
}
