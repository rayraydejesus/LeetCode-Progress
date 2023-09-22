## 1768. Merge Strings Alternately

**Link**:
</br>[Leet Code Problem 1768](https://leetcode.com/problems/merge-strings-alternately/)

**Solution**:
</br>[Source code](./Solutions/Solution_1768.cs)

**Analysis**:
```
Time : O(n)
Space : O(m + n)
```
<p><em>By finding the shorter length we can further optimize run time but worst case is still O(n) if the length of both strings are the same.
Our space complexity of O(m+n) comes from the joining of both strings. However use of a StringBuilder allows for use to reduce overhead on garbage collection.</em></p>

**Problem Description**
---------------------------------
You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

Return the merged string.

**Examples:**
```
Example 1:

Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"
Explanation: The merged string will be merged as so:
word1:  a   b   c
word2:    p   q   r
merged: a p b q c r
Example 2:

Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"
Explanation: Notice that as word2 is longer, "rs" is appended to the end.
word1:  a   b 
word2:    p   q   r   s
merged: a p b q   r   s
Example 3:

Input: word1 = "abcd", word2 = "pq"
Output: "apbqcd"
Explanation: Notice that as word1 is longer, "cd" is appended to the end.
word1:  a   b   c   d
word2:    p   q 
merged: a p b q c   d
```

**Constraints:**
```
1 <= word1.length, word2.length <= 100
word1 and word2 consist of lowercase English letters.
```