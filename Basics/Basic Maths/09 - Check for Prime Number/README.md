# Check for Prime Number

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Math, Number Theory, Prime Numbers, Loops, Divisors

---

## ❓ Question

Given an integer `n`, determine whether it is a **Prime Number**.

A **Prime Number** is a positive integer greater than `1` that has exactly **two distinct positive divisors**:

* `1`
* The number itself

Return:

* `true` if `n` is prime.
* `false` otherwise.

---

## 💡 Approach

A number is prime if it has no divisors other than `1` and itself.

Instead of checking every number from `2` to `n - 1`, we only need to check divisibility up to **√n**.

### Why only up to √n?

If `n` has a divisor greater than `√n`, then it must also have a corresponding divisor smaller than `√n`.

For example:

```text
36 = 4 × 9
```

Since one factor (`4`) is less than `√36 = 6`, checking beyond the square root is unnecessary.

### Steps

1. If `n` is less than or equal to `1`, return `false`.
2. Iterate from `2` to `√n`.
3. If `n` is divisible by any number in this range:

   * Return `false`.
4. If no divisor is found, return `true`.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 5
```

**Output**

```text
true
```

**Explanation**

The only divisors of `5` are:

```text
1, 5
```

Since it has exactly two divisors, it is a prime number.

---

### Example 2

**Input**

```text
n = 8
```

**Output**

```text
false
```

**Explanation**

The divisors of `8` are:

```text
1, 2, 4, 8
```

Since it has more than two divisors, it is not a prime number.

---

### Example 3

**Input**

```text
n = 9
```

**Output**

```text
false
```

**Explanation**

`9` is divisible by `3`.

```text
9 = 3 × 3
```

Therefore, it is not a prime number.

---

## ⏱️ Time Complexity

**O(√n)**

The algorithm checks divisibility only up to the square root of the number, making it much more efficient than checking all numbers up to `n`.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Prime numbers
* Number theory
* Divisor checking
* Square root optimization
* Loops
* Modulus operator (`%`)
* Mathematical reasoning
* Basic C# syntax

---

## ✅ Key Takeaway

This problem introduces one of the most important optimizations in number theory: **checking divisibility only up to the square root of a number**. This reduces the time complexity from **O(n)** to **O(√n)** and is the standard approach used in coding interviews. Understanding this optimization is essential for solving advanced problems involving prime numbers, factorization, and sieve algorithms.
