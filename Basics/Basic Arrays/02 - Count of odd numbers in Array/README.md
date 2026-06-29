# Count of Odd Numbers in Array

## 📌 Platform

**TakeUForward (TUF)**

## 🟢 Difficulty

**Easy**

## 🏷️ Tags

* Arrays
* Traversal
* Counting
* Mathematics
* Modulo Operator

---

## ❓ Question

Given an array of `n` elements, count the number of **odd numbers** present in the array.

Return the total count of odd elements.

### Constraints

* `1 ≤ n ≤ 10⁵`
* `1 ≤ arr[i] ≤ 10⁴`

---

## 💡 Approach

Traverse the array one element at a time.

For each element, check whether it is odd using the modulo operator (`%`). If the remainder when divided by `2` is not `0`, increment the count.

After processing all elements, return the final count.

---

## 📝 Examples

### Example 1

**Input**

```text id="k7m2ra"
n = 5
array = [1, 2, 3, 4, 5]
```

**Output**

```text id="x4q8ny"
3
```

**Explanation**

The odd elements are:

* `1`
* `3`
* `5`

Hence, the answer is **3**.

---

### Example 2

**Input**

```text id="c9v5ph"
n = 6
array = [1, 2, 1, 1, 5, 1]
```

**Output**

```text id="j6t3lw"
5
```

**Explanation**

The odd elements are:

* `1`
* `1`
* `1`
* `5`
* `1`

Hence, the answer is **5**.

---

### Example 3

**Input**

```text id="m2z7ek"
n = 5
array = [1, 3, 5, 7, 9]
```

**Output**

```text id="r5d9af"
5
```

**Explanation**

All five elements are odd.

Hence, the answer is **5**.

---

## ⏱️ Time Complexity

**O(n)**

Each array element is visited exactly once.

---

## 💾 Space Complexity

**O(1)**

Only a single counter variable is used.

---

## 📚 Concepts Practiced

* Array Traversal
* Counting Elements
* Odd and Even Numbers
* Modulo Operator (`%`)
* Conditional Statements
* Time Complexity Analysis

---

## ✅ Key Takeaway

This problem strengthens the understanding of **array traversal** and the use of the **modulo operator** to classify numbers. The counting pattern used here is a fundamental technique that frequently appears in array, searching, and filtering problems.
