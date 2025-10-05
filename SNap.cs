namespace Leetcode;

public class SnapshotArray {

    public class ArrElem{
        public int Val;
        public int SnapId;
        public ArrElem(int val = 0, int snapid = 0){
            Val = val;
            SnapId = snapid;
        }
    }

    public List<List<ArrElem>> arr;
    public int SnapCounter = 0;
    public SnapshotArray(int length) {
        arr = new (length);
        for(int i = 0; i < length; i++){
            var tempList = new List<ArrElem>(){new ArrElem(0, SnapCounter)};
            arr.Add(tempList);
        }
    }
    
    public void Set(int index, int val) {
        if(arr[index][arr[index].Count - 1].SnapId == SnapCounter) {
            arr[index][arr[index].Count - 1].Val = val;
        }
        else {
            arr[index].Add(new ArrElem(val, SnapCounter));
        }
    }
    
    public int Snap() {
        return SnapCounter++;   
    }
    
    public int Get(int index, int snap_id)
    {
        int i = 0;
        int res = arr[index][0].Val;
        foreach (var elem in arr[index])
        {
            if (elem.SnapId == snap_id)
            {
                return elem.Val;
            }
            else if(elem.SnapId > snap_id)
            {
                return res;
            }
            else
            {
                res = elem.Val;
            }
        }

        return res;
    }
}

/**
 * Your SnapshotArray object will be instantiated and called as such:
 * SnapshotArray obj = new SnapshotArray(length);
 * obj.Set(index,val);
 * int param_2 = obj.Snap();
 * int param_3 = obj.Get(index,snap_id);
 */