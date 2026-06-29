# Sum of Array Elements

## 📌 Platform

**TakeUForward (TUF)**

## 🟢 Difficulty

**Easy**

## 🏷️ Tags

* Arrays
* Traversal
* Iteration
* Basic Programming

---

## ❓ Question

Given an array `arr` of size `n`, find the **sum of all its elements**.

Return the total sum of the array.

### Constraints

* `1 ≤ n ≤ 10⁵`
* `1 ≤ arr[i] ≤ 10⁴`

---

## 💡 Approach

Initialize a variable to store the sum as `0`.

Traverse the array from the first element to the last, adding each element to the running total. After processing all elements, return the accumulated sum.

Since each element is visited exactly once, this is the most efficient approach.

---

## 📝 Examples

### Example 1

**Input**

```text id="b3q9zw"
n = 5
arr = [1, 2, 3, 4, 5]
```

**Output**

```text id="f7l2xa"
15
```

**Explanation**

Sum of all elements:

* `1 + 2 + 3 + 4 + 5 = 15`

Hence, the answer is **15**.

---

### Example 2

**Input**

```text id="n6d4pe"
n = 6
arr = [1, 2, 1, 1, 5, 1]
```

**Output**

```text id="r8v1kh"
11
```

**Explanation**

Sum of all elements:

* `1 + 2 + 1 + 1 + 5 + 1 = 11`

Hence, the answer is **11**.

---

## ⏱️ Time Complexity

**O(n)**

Each element is visited exactly once.

---

## 💾 Space Complexity

**O(1)**

Only a single variable is used to store the running sum.

---

## 📚 Concepts Practiced

* Array Traversal
* Iteration
* Running Sum
* Accumulator Pattern
* Time Complexity Analysis

---

## ✅ Key Takeaway

This problem reinforces one of the most fundamental array operations—**linear traversal with an accumulator**. Mastering this pattern is essential, as it forms the basis for solving many more advanced array and prefix sum problems.
