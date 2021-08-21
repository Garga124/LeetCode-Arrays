//Time Complexity: O(N + K * log(N))
// Space: O(N)
public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        if(points == null){
            return points;
        }
        
        PriorityQueue<Point> pq = new PriorityQueue<Point>(true);
        int total = k;
        for(int i=0;i<points.Length;i++){
            int dist = GetDistance(points[i]);
            if(total>0){
                pq.Enqueue(new Point(dist,points[i][0],points[i][1]));
                total --;
            }else{
                if(dist<pq.Peek().distance){
                    pq.Dequeue();
                   pq.Enqueue(new Point(dist,points[i][0],points[i][1]));
                }
            }
        }
        List<int[]> ans = new List<int[]>(k);
         while(pq.Count>0)
        {
            var cur = pq.Dequeue();
            ans.Add(new int[2]{cur.x,cur.y});
        }
        
        return ans.ToArray();
         
        //return points;
        
    }
     private int GetDistance(int[] cord)
    {
        return Convert.ToInt32(Math.Pow(cord[0],2) + Math.Pow(cord[1],2));
    }
    
    
    public class Point : IComparable{
        public int distance;
        public int x;
        public int y;
        
        public Point(int distance, int x, int y){
            this.distance = distance;
            this.x = x;
            this.y = y;
        }
        public int CompareTo(Object obj){
            Point other = obj as Point;
            if(other != null){
                return this.distance.CompareTo(other.distance);
            }
            else{
                throw new Exception("Invalid Cast");
            }
        }
    }
    
   public class PriorityQueue<T> where T : IComparable
{
    private List<T> list;
    public int Count { get { return list.Count; } }
    public readonly bool IsDescending;

    public PriorityQueue()
    {
        list = new List<T>();
    }

    public PriorityQueue(bool isdesc)
        : this()
    {
        IsDescending = isdesc;
    }

    public PriorityQueue(int capacity)
        : this(capacity, false)
    { }

    public PriorityQueue(IEnumerable<T> collection)
        : this(collection, false)
    { }

    public PriorityQueue(int capacity, bool isdesc)
    {
        list = new List<T>(capacity);
        IsDescending = isdesc;
    }

    public PriorityQueue(IEnumerable<T> collection, bool isdesc)
        : this()
    {
        IsDescending = isdesc;
        foreach (var item in collection)
            Enqueue(item);
    }


    public void Enqueue(T x)
    {
        list.Add(x);
        int i = Count - 1;

        while (i > 0)
        {
            int p = (i - 1) / 2;
            if ((IsDescending ? -1 : 1) * list[p].CompareTo(x) <= 0) break;

            list[i] = list[p];
            i = p;
        }

        if (Count > 0) list[i] = x;
    }

    public T Dequeue()
    {
        T target = Peek();
        T root = list[Count - 1];
        list.RemoveAt(Count - 1);

        int i = 0;
        while (i * 2 + 1 < Count)
        {
            int a = i * 2 + 1;
            int b = i * 2 + 2;
            int c = b < Count && (IsDescending ? -1 : 1) * list[b].CompareTo(list[a]) < 0 ? b : a;

            if ((IsDescending ? -1 : 1) * list[c].CompareTo(root) >= 0) break;
            list[i] = list[c];
            i = c;
        }

        if (Count > 0) list[i] = root;
        return target;
    }

    public T Peek()
    {
        if (Count == 0) throw new InvalidOperationException("Queue is empty.");
        return list[0];
    }

    public void Clear()
    {
        list.Clear();
    }
}

}