# LCM of Two Numbers

## 📌 Platform

**TakeUForward (TUF)**

## 🟢 Difficulty

**Easy**

## 🏷️ Tags

* Mathematics
* Number Theory
* Lowest Common Multiple (LCM)
* Greatest Common Divisor (GCD)
* Euclidean Algorithm

---

## ❓ Question

Given two integers `n1` and `n2`, find their **Lowest Common Multiple (LCM)**.

The **Lowest Common Multiple (LCM)** of two integers is the smallest positive integer that is divisible by both numbers.

Return the LCM of the given numbers.

### Constraints

* `1 ≤ n1, n2 ≤ 1000`

---

## 💡 Approach

A straightforward approach is to start from the larger of the two numbers and keep checking the next multiples until a number divisible by both is found.

A much more efficient approach is to first compute the **Greatest Common Divisor (GCD)** using the **Euclidean Algorithm**, then use the mathematical relationship:

```text
LCM(a, b) = (a × b) / GCD(a, b)
```

This avoids unnecessary iterations and computes the answer efficiently.

---

## 📝 Examples

### Example 1

**Input**

```text id="k9x7pa"
n1 = 4, n2 = 6
```

**Output**

```text id="tv5r2m"
12
```

**Explanation**

* `4 × 3 = 12`
* `6 × 2 = 12`

The smallest number divisible by both `4` and `6` is **12**.

---

### Example 2

**Input**

```text id="g1n6zy"
n1 = 3, n2 = 5
```

**Output**

```text id="m8q2jh"
15
```

**Explanation**

* `3 × 5 = 15`
* `5 × 3 = 15`

The smallest number divisible by both `3` and `5` is **15**.

---

### Example 3

**Input**

```text id="x5v8lw"
n1 = 4, n2 = 12
```

**Output**

```text id="q4j1ec"
12
```

**Explanation**

Since `12` is already a multiple of `4` and `12`, it is the lowest common multiple.

---

## ⏱️ Time Complexity

* **Brute Force:** `O(LCM)` (can be inefficient for larger values)
* **Using GCD (Optimal):** `O(log(min(n1, n2)))`

---

## 💾 Space Complexity

* **Iterative GCD Approach:** `O(1)`
* **Recursive GCD Approach:** `O(log(min(n1, n2)))`

---

## 📚 Concepts Practiced

* Lowest Common Multiple (LCM)
* Greatest Common Divisor (GCD)
* Euclidean Algorithm
* Number Theory
* Mathematical Relationships
* Time Complexity Analysis

---

## ✅ Key Takeaway

This problem demonstrates the strong relationship between **LCM** and **GCD**. Instead of searching for common multiples, using the identity **`LCM(a, b) = (a × b) / GCD(a, b)`** with the **Euclidean Algorithm** provides an elegant and highly efficient solution that is widely used in mathematics and competitive programming.
