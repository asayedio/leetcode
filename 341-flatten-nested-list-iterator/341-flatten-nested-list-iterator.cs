/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class NestedIterator {

    private Queue<int> q = new Queue<int>();

            public NestedIterator(IList<NestedInteger> nestedList)
            {
                foreach (var item in nestedList)
                    DFS(item);
            }

            public bool HasNext()
            {
                return q.Count != 0;
            }

            public int Next()
            {
                return q.Count == 0 ? 0 : q.Dequeue();
            }

            private void DFS(NestedInteger cur)
            {
                if (cur.IsInteger())
                    q.Enqueue(cur.GetInteger());
                else
                    foreach (var item in cur.GetList())
                        DFS(item);
            }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */