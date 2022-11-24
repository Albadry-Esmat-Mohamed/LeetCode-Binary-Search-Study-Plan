public class Solution {
    public bool IsPerfectSquare(int num) {
     
                        long low = 0;
                long mid = 0;
                long sqrmid = 0;
                long high = num / 2;

                if( num == 1 ) { return true; }
                while(low <= high)
                {
                    mid= (low + high) / 2;
                    sqrmid = (mid * mid);
                    if(sqrmid < 0 ) { sqrmid *= -1; }
                    
                    if(sqrmid == num) {return true;}
                    if(sqrmid > num) high= mid - 1;
                    if(sqrmid < num ) low= mid + 1;
                }
                
                return false;




        
    }
}