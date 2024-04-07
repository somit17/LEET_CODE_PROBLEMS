public class Solution {
    private Dictionary<int, bool> visted = new();
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
for(int i=0;i<rooms.Count;i++)
        {
            visted[i] = false;
        }
        DFS(0, rooms, visted);
        foreach (bool x in visted.Values)
        {
            if (!x) return false;
        }

        return true;
    }
    public void DFS(int source, IList<IList<int>> rooms, Dictionary<int, bool> visted)
    {
        visted[source] = true;
        foreach (var room in rooms[source])
        {
            if (!visted[room])
            {
                DFS(room, rooms, visted);
            }
        }
    }
}