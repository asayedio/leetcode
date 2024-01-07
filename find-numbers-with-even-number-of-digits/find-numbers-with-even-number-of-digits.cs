public class Solution {
    public int FindNumbers(int[] nums) {
        int numberOfEvens = 0;
        
        for(int i = 0; i < nums.Length; i++){
            int numberOfDigits = 0;
            while(nums[i] > 0){
                numberOfDigits++; 
                nums[i] = nums[i] / 10;
            }
            
            if(numberOfDigits%2 == 0){
                numberOfEvens++;
            }
        }
        
        return numberOfEvens;
    }
}