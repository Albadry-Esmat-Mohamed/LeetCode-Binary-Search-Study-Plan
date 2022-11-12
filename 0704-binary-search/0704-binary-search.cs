public class Solution {
    public int Search(int[] nums, int target) {
        int low = 0;
        int high = nums.Length - 1;
        int mid;
        while( low <= high )
        {
            mid = (low + high)/2 ; 

            if(nums[mid] > target ) 
            {
                high =  mid -1;
                continue;
            }
            if(nums[mid] < target )
            {
                low = mid + 1;
                continue;
            }
            
            if(nums[low] == target ) return low;
            if(nums[high] == target ) return high;
            
            return mid;
        }
        return -1 ;
    }
}