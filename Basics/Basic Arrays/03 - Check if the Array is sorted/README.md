# Check if the Array is Sorted I

## 📌 Platform

**TakeUForward (TUF)**

## 🟢 Difficulty

**Easy**

## 🏷️ Tags

* Arrays
* Traversal
* Sorted Array
* Greedy
* Basic Programming

---

## ❓ Question

Given an array `arr` of size `n`, determine whether the array is sorted in **ascending (non-decreasing)** order.

An array is considered sorted if every element is **less than or equal to** its next element.

Return:

* **True** if the array is sorted.
* **False** otherwise.

### Constraints

* `1 ≤ n ≤ 10⁶`
* `-10⁹ ≤ arr[i] ≤ 10⁹`

---

## 💡 Approach

Traverse the array from the first element to the second-last element.

For each index `i`, compare `arr[i]` with `arr[i + 1]`.

* If `arr[i] > arr[i + 1]`, the ascending order is violated, so return **False** immediately.
* If no such pair exists throughout the traversal, the array is sorted, so return **True**.

This approach checks each adjacent pair exactly once and terminates early if an unsorted pair is found.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 5
arr = [1, 2, 3, 4, 5]
```

**Output**

```text
True
```

**Explanation**

Each element is less than or equal to its next element:

* `1 ≤ 2`
* `2 ≤ 3`
* `3 ≤ 4`
* `4 ≤ 5`

Hence, the array is sorted.

---

### Example 2

**Input**

```text
n = 5
arr = [5, 4, 6, 7, 8]
```

**Output**

```text
False
```

**Explanation**

The first adjacent pair violates the sorted order:

* `5 > 4`

Therefore, the array is not sorted.

---

### Example 3

**Input**

```text
n = 5
arr = [5, 4, 3, 2, 1]
```

**Output**

```text
False
```

**Explanation**

The array is in strictly decreasing order, so it does not satisfy the non-decreasing condition.

---

## ⏱️ Time Complexity

**O(n)**

Each adjacent pair is checked at most once.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra memory is used.

---

## 📚 Concepts Practiced

* Array Traversal
* Adjacent Element Comparison
* Sorted Arrays
* Early Termination
* Greedy Checking
* Time Complexity Analysis

---

## ✅ Key Takeaway

This problem introduces the standard technique for **verifying sorted order** by comparing adjacent elements. The idea of **terminating immediately upon finding a violation** is an important optimization used in many array and validation algorithms.
