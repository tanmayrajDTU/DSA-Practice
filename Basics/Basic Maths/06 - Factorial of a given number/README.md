# Factorial of a Given Number

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Math, Loops, Recursion, Basics

---

## ❓ Question

Given an integer `n`, return the value of **`n!` (n factorial)**.

The factorial of a number is the product of all positive integers less than or equal to that number.

Mathematically,

```text
n! = n × (n - 1) × (n - 2) × ... × 2 × 1
```

By definition,

```text
0! = 1
```

---

## 💡 Approach

The factorial can be calculated by multiplying all integers from `1` to `n`.

### Steps

1. Initialize a variable `factorial` to `1`.
2. Iterate from `1` to `n` using a loop.
3. Multiply the current value of `factorial` by the loop variable.
4. After the loop completes, return `factorial`.

> **Note:** When `n = 0`, the loop does not execute, and the initial value `1` is returned, which correctly represents `0!`.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 2
```

**Output**

```text
2
```

**Explanation**

```text
2! = 2 × 1 = 2
```

---

### Example 2

**Input**

```text
n = 0
```

**Output**

```text
1
```

**Explanation**

By definition,

```text
0! = 1
```

---

### Example 3

**Input**

```text
n = 3
```

**Output**

```text
6
```

**Explanation**

```text
3! = 3 × 2 × 1 = 6
```

---

## ⏱️ Time Complexity

**O(n)**

The loop executes exactly `n` times.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Loops
* Iterative algorithms
* Mathematical computation
* Factorial calculation
* Basic C# syntax

---

## ✅ Key Takeaway

This problem introduces **factorial computation**, one of the most fundamental mathematical operations in programming. It demonstrates how repetitive multiplication can be implemented using a loop while reinforcing the concept of maintaining a running product. Factorials are widely used in **combinatorics, permutations, combinations, probability, recursion, and dynamic programming**, making this an essential concept for coding interviews.
