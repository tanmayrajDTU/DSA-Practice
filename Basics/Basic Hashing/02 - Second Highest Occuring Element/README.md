# Second Highest Occurring Element

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

Given an array of `n` integers, find the **second most frequent element**.

* If multiple elements have the same second-highest frequency, return the **smallest** among them.
* If a second most frequent element does not exist, return **`-1`**.

### Constraints

* `1 ≤ n ≤ 10⁵`
* `1 ≤ arr[i] ≤ 10⁴`

---

## 💡 Approach

Use a **Hash Map (or Frequency Array)** to count the frequency of each element.

1. Traverse the array and record the frequency of every element.
2. Determine the highest and second-highest distinct frequencies.
3. Among all elements having the second-highest frequency, select the **smallest** one.
4. If all elements have the same frequency (i.e., no second-highest frequency exists), return **`-1`**.

This approach efficiently computes the required answer while handling tie-breaking correctly.

---

## 📝 Examples

### Example 1

**Input**

```text id="m4q8xp"
arr = [1, 2, 2, 3, 3, 3]
```

**Output**

```text id="z7c2ha"
2
```

**Explanation**

Frequency of each element:

* `1 → 1`
* `2 → 2`
* `3 → 3`

The highest frequency is `3`, and the second-highest frequency is `2`.

Hence, the answer is **2**.

---

### Example 2

**Input**

```text id="g9v3lm"
arr = [4, 4, 5, 5, 6, 7]
```

**Output**

```text id="k1n6dy"
6
```

**Explanation**

Frequency of each element:

* `4 → 2`
* `5 → 2`
* `6 → 1`
* `7 → 1`

The second-highest frequency is `1`.

Both `6` and `7` occur once, so the smaller element, **6**, is returned.

---

### Example 3

**Input**

```text id="t5e8qr"
arr = [10, 9, 7, 7]
```

**Output**

```text id="p2j4wb"
9
```

**Explanation**

Frequency of each element:

* `7 → 2`
* `9 → 1`
* `10 → 1`

The second-highest frequency is `1`.

Both `9` and `10` occur once, so the smaller element, **9**, is returned.

---

## ⏱️ Time Complexity

**O(n)**

The array is traversed to compute frequencies, followed by processing the distinct elements to determine the second-highest frequency.

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
* Counting Techniques
* Time Complexity Analysis

---

## ✅ Key Takeaway

This problem extends the concept of **frequency counting** by introducing **ranking based on frequency** and **tie-breaking conditions**. It reinforces the use of hashing for efficiently solving counting problems, a technique that frequently appears in coding interviews and competitive programming.
