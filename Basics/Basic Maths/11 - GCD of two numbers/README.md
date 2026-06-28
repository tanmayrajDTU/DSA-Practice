# GCD of Two Numbers

## 📌 Platform

**TakeUForward (TUF)**

## 🟢 Difficulty

**Easy**

## 🏷️ Tags

* Mathematics
* Number Theory
* Greatest Common Divisor (GCD)
* Euclidean Algorithm

---

## ❓ Question

Given two integers `n1` and `n2`, find their **Greatest Common Divisor (GCD)**.

The **Greatest Common Divisor (GCD)** of two integers is the largest positive integer that divides both numbers without leaving a remainder.

Return the GCD of the given numbers.

### Constraints

* `1 ≤ n1, n2 ≤ 1000`

---

## 💡 Approach

A simple approach is to check all numbers from `1` up to the smaller of the two numbers and keep track of the largest common divisor.

A more efficient solution is the **Euclidean Algorithm**, which repeatedly replaces the larger number with the remainder obtained after dividing it by the smaller number. The process continues until the remainder becomes `0`. The remaining non-zero number is the GCD.

---

## 📝 Examples

### Example 1

**Input**

```text
n1 = 4, n2 = 6
```

**Output**

```text
2
```

**Explanation**

Divisors of `4` are: `1, 2, 4`

Divisors of `6` are: `1, 2, 3, 6`

The greatest common divisor is **2**.

---

### Example 2

**Input**

```text
n1 = 9, n2 = 8
```

**Output**

```text
1
```

**Explanation**

Divisors of `9` are: `1, 3, 9`

Divisors of `8` are: `1, 2, 4, 8`

The only common divisor is `1`, so the GCD is **1**.

---

### Example 3

**Input**

```text
n1 = 6, n2 = 12
```

**Output**

```text
6
```

**Explanation**

Divisors of `6` are: `1, 2, 3, 6`

Divisors of `12` are: `1, 2, 3, 4, 6, 12`

The greatest common divisor is **6**.

---

## ⏱️ Time Complexity

* **Brute Force:** `O(min(n1, n2))`
* **Euclidean Algorithm (Optimal):** `O(log(min(n1, n2)))`

---

## 💾 Space Complexity

* **Iterative Euclidean Algorithm:** `O(1)`
* **Recursive Euclidean Algorithm:** `O(log(min(n1, n2)))`

---

## 📚 Concepts Practiced

* Greatest Common Divisor (GCD)
* Number Theory
* Euclidean Algorithm
* Modulo Operation
* Mathematical Optimization
* Time Complexity Analysis

---

## ✅ Key Takeaway

This problem introduces one of the most fundamental algorithms in mathematics and computer science—the **Euclidean Algorithm**. Understanding this technique is essential, as it serves as the foundation for solving many advanced problems involving fractions, modular arithmetic, coprime numbers, and competitive programming.
