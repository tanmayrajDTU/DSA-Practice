# Highest Occurring Element in an Array

## 📌 Platform

**TakeUForward (TUF)**

## 🟢 Difficulty

**Easy**

## 🏷️ Tags

* Arrays
* Hashing
* Frequency Counting
* Hash Map
* Counting

---

## ❓ Question

Given an integer array `nums` of size `n`, find the element that occurs **most frequently**.

If multiple elements have the same highest frequency, return the **smallest** among them.

### Constraints

* `1 ≤ n ≤ 10⁵`
* `1 ≤ nums[i] ≤ 10⁴`

---

## 💡 Approach

Use a **Hash Map (or Frequency Array)** to count the occurrences of each element.

1. Traverse the array and store the frequency of every element.
2. Iterate through the recorded frequencies.
3. Keep track of:

   * The maximum frequency encountered.
   * The corresponding element.
4. If another element has the same maximum frequency, choose the **smaller** element.

This approach counts frequencies in linear time and efficiently handles the tie-breaking condition.

---

## 📝 Examples

### Example 1

**Input**

```text id="q4n8ta"
nums = [1, 2, 2, 3, 3, 3]
```

**Output**

```text id="v2k6pd"
3
```

**Explanation**

Frequency of each element:

* `1 → 1`
* `2 → 2`
* `3 → 3`

Since `3` appears the most, the answer is **3**.

---

### Example 2

**Input**

```text id="f7m3rx"
nums = [4, 4, 5, 5, 6]
```

**Output**

```text id="c1y9jh"
4
```

**Explanation**

Frequency of each element:

* `4 → 2`
* `5 → 2`
* `6 → 1`

Both `4` and `5` have the highest frequency, but `4` is smaller.

Hence, the answer is **4**.

---

### Example 3

**Input**

```text id="h5z2we"
nums = [2, 4, 3, 2, 5, 4]
```

**Output**

```text id="m8q7ln"
2
```

**Explanation**

Frequency of each element:

* `2 → 2`
* `4 → 2`
* `3 → 1`
* `5 → 1`

Both `2` and `4` occur twice, so the smaller element, **2**, is returned.

---

## ⏱️ Time Complexity

**O(n)**

The array is traversed once to count frequencies, and the stored frequencies are processed to determine the answer.

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
* Tie-Breaking Logic
* Time Complexity Analysis

---

## ✅ Key Takeaway

This problem introduces one of the most common applications of **hashing**—efficient frequency counting. The frequency map pattern is fundamental in array problems and serves as the basis for solving many advanced questions involving duplicates, majority elements, grouping, and counting occurrences.
