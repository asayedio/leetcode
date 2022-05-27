public class Solution {
    public int NumberOfSteps (int num) {
        int stepsNum = 0;
            while (num > 0)
            {
                if (num % 2 == 0)
                    num /= 2;
                else
                    num--;
                stepsNum++;
            }
            return stepsNum;
    }
}