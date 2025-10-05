namespace Task_1486;

public class Solution {
    public int XorOperation(int n, int start) {
        int res = 0;
        int xorElem = start;
        int i = 0;
        while(i < n){
            xorElem = start + i * 2;
            res = xorElem ^ res;
            i++;
        }
        
        return res;
    }
}