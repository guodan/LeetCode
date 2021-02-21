using System.Collections.Generic;
using System;
public class SolutionTwoSum {//224ms
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++){
                for(int j = i + 1; j< nums.Length; j++){
                    if(nums[i] + nums[j] == target){
                        return new int[2]{i,j};
                    }
                }
            }
        return null;
    }
    public int[] TwoSum_Dictionary(int[] nums, int target) {//240ms
        Dictionary<int, int> numDictionary = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            int temp = target - nums[i];
            int index = 0;
            if(numDictionary.TryGetValue(temp, out index)){
                return new int[]{i, index};
            }
            if(!numDictionary.ContainsKey(nums[i])){
                numDictionary.Add(nums[i], i);
            }
        }
        return null;
    }
}