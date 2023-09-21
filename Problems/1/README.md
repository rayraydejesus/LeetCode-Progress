## 1. Two Sum

**Link**:
</br>[Leet Code Problem 1](https://leetcode.com/problems/two-sum/)

**Solution**:
</br>[Source code](./Solutions/Solution_1_Hashmap.cs)

**Analysis**:
```
Time : O(n)
Space : O(n)
```

<p><em>By using a hashmap we are able reduce lookup times to O(1). This removes the need to search the array again for every element O(n^2).
Our worst case of O(n) space comes from every element being unique and the last element being the complimenting value.</em></p>

**Problem Description**
---------------------------------
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 
**Examples:**
```
Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]

Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 ```

**Constraints:**
```
2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.
```
