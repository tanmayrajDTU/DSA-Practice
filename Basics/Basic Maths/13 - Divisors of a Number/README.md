# Divisors of a Number

## 📌 Platform

**TakeUForward (TUF)**

## 🟢 Difficulty

**Easy**

## 🏷️ Tags

* Mathematics
* Number Theory
* Divisors
* Square Root Optimization

---

## ❓ Question

Given an integer `n`, find **all of its divisors** and return them in **sorted order**.

A **divisor** of a number is an integer that divides the number exactly without leaving any remainder.

### Constraints

* `1 ≤ n ≤ 1000`

---

## 💡 Approach

A basic approach is to iterate from `1` to `n` and check whether each number divides `n`. If it does, include it in the result.

A more efficient approach is to iterate only up to `√n`. Whenever a divisor `i` is found, its corresponding paired divisor `n / i` is also a divisor. Collect both divisors, handle perfect squares carefully to avoid duplicates, and sort the final list before returning it.

---

## 📝 Examples

### Example 1

**Input**

```text id="9kq5mu"
n = 6
```

**Output**

```text id="3zt8pw"
[1, 2, 3, 6]
```

**Explanation**

The numbers that divide `6` without leaving a remainder are:

* `1`
* `2`
* `3`
* `6`

Hence, the divisors are **[1, 2, 3, 6]**.

---

### Example 2

**Input**

```text id="m7x2hf"
n = 8
```

**Output**

```text id="j4r9vc"
[1, 2, 4, 8]
```

**Explanation**

The numbers that divide `8` exactly are:

* `1`
* `2`
* `4`
* `8`

Hence, the divisors are **[1, 2, 4, 8]**.

---

### Example 3

**Input**

```text id="a5n8ly"
n = 7
```

**Output**

```text id="t2e6qj"
[1, 7]
```

**Explanation**

Since `7` is a prime number, its only divisors are `1` and `7`.

---

## ⏱️ Time Complexity

* **Brute Force:** `O(n)`
* **Square Root Optimization:** `O(√n log √n)` *(including sorting of collected divisors)*

---

## 💾 Space Complexity

* **Auxiliary Space:** `O(k)`

Where `k` is the number of divisors stored in the result.

---

## 📚 Concepts Practiced

* Divisors
* Number Theory
* Square Root Optimization
* Factor Pairs
* Sorting
* Time Complexity Analysis

---

## ✅ Key Takeaway

This problem introduces the important observation that **divisors occur in pairs**. By iterating only up to **`√n`**, the solution becomes significantly more efficient than checking every number, making it a common optimization technique in number theory and competitive programming.
