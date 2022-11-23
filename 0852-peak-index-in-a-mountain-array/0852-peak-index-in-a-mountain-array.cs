public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        
           int low = 0, high = arr.Length -1, mid;

                while (low <= high)
                {
                    mid = (low + high) / 2;

            

                    if (arr[mid] > arr[mid - 1] )
                    {
                        if (arr[mid] > arr[mid + 1])
                            return mid;
                        else
                            low = mid + 1;
                        continue;
                    }
                    else if (arr[mid] < arr[mid -1])
                    {
                        high = mid ;
                    }

                }

                return -1;

    }
}