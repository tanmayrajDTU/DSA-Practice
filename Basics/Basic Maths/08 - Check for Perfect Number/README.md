# Check for Perfect Number

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Math, Number Theory, Loops, Divisors, Basics

---

## ❓ Question

Given an integer `n`, determine whether it is a **Perfect Number**.

A **Perfect Number** is a positive integer whose **proper divisors** (excluding the number itself) add up to the number itself.

Return:

* `true` if `n` is a Perfect Number.
* `false` otherwise.

---

## 💡 Approach

A proper divisor of a number is a positive divisor other than the number itself.

To determine whether a number is perfect:

### Steps

1. Initialize a variable `sum` to `0`.
2. Iterate from `1` to `n / 2`.

   * A number cannot have a proper divisor greater than `n / 2` (except itself).
3. For every number that divides `n` exactly (`n % i == 0`):

   * Add it to `sum`.
4. After the loop, compare `sum` with `n`.
5. If both are equal, return `true`; otherwise, return `false`.

---

## 📝 Examples

### Example 1

**Input**

```text id="2v55pb"
n = 6
```

**Output**

```text id="8d46eh"
true
```

**Explanation**

The proper divisors of `6` are:

```text id="9ahdc6"
1, 2, 3
```

Their sum is:

```text id="dbn1wd"
1 + 2 + 3 = 6
```

Since the sum equals the original number, `6` is a Perfect Number.

---

### Example 2

**Input**

```text id="ybf3i2"
n = 4
```

**Output**

```text id="ovb7yk"
false
```

**Explanation**

The proper divisors of `4` are:

```text id="o1d9fm"
1, 2
```

Their sum is:

```text id="ncr2ul"
1 + 2 = 3
```

Since `3 ≠ 4`, the number is **not** a Perfect Number.

---

### Example 3

**Input**

```text id="rjlwmz"
n = 28
```

**Output**

```text id="jtv5fe"
true
```

**Explanation**

The proper divisors of `28` are:

```text id="dcb3t4"
1, 2, 4, 7, 14
```

Their sum is:

```text id="l98fqx"
1 + 2 + 4 + 7 + 14 = 28
```

Since the sum equals the original number, `28` is a Perfect Number.

---

## ⏱️ Time Complexity

**O(n)**

The algorithm checks all integers from `1` to `n / 2`, resulting in linear time complexity.

> **Note:** An optimized solution can iterate only up to `√n`, reducing the complexity to **O(√n)**.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Loops
* Divisor computation
* Modulus operator (`%`)
* Number theory
* Mathematical reasoning
* Basic C# syntax

---

## ✅ Key Takeaway

This problem introduces the concept of **proper divisors** and demonstrates how divisor-based algorithms can be used to classify numbers. It reinforces divisor iteration, modulus operations, and accumulation techniques, while also highlighting that many divisor-related problems can be optimized by iterating only up to the square root of the number.
