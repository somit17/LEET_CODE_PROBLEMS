public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        //Build adj List
        Dictionary<int,List<int>> adjList= new Dictionary<int,List<int>>();
        int n=rooms.Count;
        for(int i=0;i<n;i++){
            adjList[i]=new List<int>(rooms[i]);
        }
        
        //BFS
        
        Queue<int> queue= new Queue<int>();
        bool[] visited= new bool[n];
        queue.Enqueue(0);
        visited[0]=true;
        
        while(queue.Count>0){
            var currentNode=queue.Dequeue();
            foreach(var v in adjList[currentNode]){
                if(!visited[v]){
                    queue.Enqueue(v);
                    visited[v]=true;
                }
            }
        }
        
        for(int i=0;i<n;i++)
            if(!visited[i])
                return false;
        
        return true;
        
        
    }
}