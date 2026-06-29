# Reverse an Array

## 📌 Platform

**TakeUForward (TUF)**

## 🟢 Difficulty

**Easy**

## 🏷️ Tags

* Arrays
* Two Pointers
* In-Place Algorithm
* Traversal

---

## ❓ Question

Given an array `arr` of `n` elements, reverse the array **in-place**.

The reversal should be performed without using an additional array.

### Constraints

* `1 ≤ n ≤ 10⁴`
* `1 ≤ arr[i] ≤ 10⁵`

---

## 💡 Approach

Use the **Two Pointers** technique.

* Initialize one pointer at the beginning of the array and another at the end.
* Swap the elements at these pointers.
* Move the left pointer one step forward and the right pointer one step backward.
* Continue this process until the two pointers meet or cross each other.

Since each swap places two elements in their correct reversed positions, the reversal is completed efficiently without using extra space.

---

## 📝 Examples

### Example 1

**Input**

```text id="u9v2ke"
n = 5
arr = [1, 2, 3, 4, 5]
```

**Output**

```text id="x4q1ta"
[5, 4, 3, 2, 1]
```

**Explanation**

Reversing the array changes the order of elements from left to right.

Original:

* `[1, 2, 3, 4, 5]`

Reversed:

* `[5, 4, 3, 2, 1]`

---

### Example 2

**Input**

```text id="l8p6hr"
n = 6
arr = [1, 2, 1, 1, 5, 1]
```

**Output**

```text id="w5m9cd"
[1, 5, 1, 1, 2, 1]
```

**Explanation**

The first and last elements are swapped, followed by the second and second-last elements, until the entire array is reversed.

---

### Example 3

**Input**

```text id="a7j3nf"
n = 3
arr = [1, 2, 1]
```

**Output**

```text id="k2z8vb"
[1, 2, 1]
```

**Explanation**

The array remains the same after reversal because it is symmetric.

---

## ⏱️ Time Complexity

**O(n)**

Each element is involved in at most one swap.

---

## 💾 Space Complexity

**O(1)**

The reversal is performed in-place without using any additional data structure.

---

## 📚 Concepts Practiced

* Array Traversal
* Two Pointers
* In-Place Algorithms
* Swapping Elements
* Space Optimization
* Time Complexity Analysis

---

## ✅ Key Takeaway

This problem introduces the **Two Pointers** technique, one of the most widely used patterns in array and string problems. Reversing an array in-place demonstrates how efficient algorithms can minimize both **time** and **space** complexity by avoiding unnecessary auxiliary storage.
