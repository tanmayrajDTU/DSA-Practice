# Sum of Highest and Lowest Frequency

## 📌 Platform

**TakeUForward (TUF)**

## 🟢 Difficulty

**Easy**

## 🏷️ Tags

* Arrays
* Hashing
* Hash Map
* Frequency Counting
* Counting

---

## ❓ Question

Given an array of `n` integers, determine the **sum of the highest frequency and the lowest frequency** among all distinct elements.

Return the sum of these two frequencies.

### Constraints

* `1 ≤ n ≤ 10⁵`
* `1 ≤ arr[i] ≤ 10⁴`

---

## 💡 Approach

Use a **Hash Map (or Frequency Array)** to count the occurrences of every distinct element.

1. Traverse the array and store the frequency of each element.
2. Iterate through the recorded frequencies.
3. Track:

   * The **maximum frequency** encountered.
   * The **minimum frequency** encountered.
4. Return the sum of the maximum and minimum frequencies.

Only the frequency values are required; the actual elements are not needed.

---

## 📝 Examples

### Example 1

**Input**

```text id="y3n8kr"
arr = [1, 2, 2, 3, 3, 3]
```

**Output**

```text id="q6v2mp"
4
```

**Explanation**

Frequency of each element:

* `1 → 1`

* `2 → 2`

* `3 → 3`

* Highest frequency = `3`

* Lowest frequency = `1`

Sum = `3 + 1 = 4`.

---

### Example 2

**Input**

```text id="j8x5cf"
arr = [4, 4, 5, 5, 6]
```

**Output**

```text id="m4z7ta"
3
```

**Explanation**

Frequency of each element:

* `4 → 2`

* `5 → 2`

* `6 → 1`

* Highest frequency = `2`

* Lowest frequency = `1`

Sum = `2 + 1 = 3`.

---

### Example 3

**Input**

```text id="r9p1ld"
arr = [10, 9, 7, 7, 8, 8, 8]
```

**Output**

```text id="w5k8ny"
4
```

**Explanation**

Frequency of each element:

* `10 → 1`

* `9 → 1`

* `7 → 2`

* `8 → 3`

* Highest frequency = `3`

* Lowest frequency = `1`

Sum = `3 + 1 = 4`.

---

## ⏱️ Time Complexity

**O(n)**

The array is traversed once to compute frequencies, followed by a traversal of the distinct elements to determine the maximum and minimum frequencies.

---

## 💾 Space Complexity

**O(n)** *(using a Hash Map)*

or

**O(k)**, where `k` is the number of distinct elements.

---

## 📚 Concepts Practiced

* Hashing
* Hash Map
* Frequency Counting
* Arrays
* Maximum and Minimum Tracking
* Time Complexity Analysis

---

## ✅ Key Takeaway

This problem reinforces the use of **hashing for frequency analysis**. Instead of identifying specific elements, the focus is on processing **frequency values**, a common pattern in interview questions involving counting, statistics, and data analysis.
