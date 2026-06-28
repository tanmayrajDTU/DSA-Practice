# Count of Prime Numbers till N

## 📌 Platform

**TakeUForward (TUF)**

## 🟢 Difficulty

**Easy**

## 🏷️ Tags

* Mathematics
* Prime Numbers
* Number Theory
* Brute Force
* Sieve of Eratosthenes (Optimization)

---

## ❓ Question

Given an integer `n`, determine the number of **prime numbers** in the range **[1, n]** (inclusive).

A **prime number** is a natural number greater than `1` that has exactly two distinct positive divisors: `1` and itself.

Return the count of all prime numbers within the given range.

### Constraints

* `2 ≤ n ≤ 1000`

---

## 💡 Approach

A straightforward solution is to iterate through every number from `2` to `n` and check whether it is prime. Count every number that satisfies the prime condition.

For better efficiency, especially for larger values of `n`, the **Sieve of Eratosthenes** can be used to precompute all prime numbers up to `n` in linearithmic time.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 6
```

**Output**

```text
3
```

**Explanation**

The prime numbers between `1` and `6` are:

* `2`
* `3`
* `5`

Hence, the answer is **3**.

---

### Example 2

**Input**

```text
n = 10
```

**Output**

```text
4
```

**Explanation**

The prime numbers between `1` and `10` are:

* `2`
* `3`
* `5`
* `7`

Hence, the answer is **4**.

---

### Example 3

**Input**

```text
n = 20
```

**Output**

```text
8
```

**Explanation**

The prime numbers between `1` and `20` are:

* `2`
* `3`
* `5`
* `7`
* `11`
* `13`
* `17`
* `19`

Hence, the answer is **8**.

---

## ⏱️ Time Complexity

* **Brute Force:** `O(n × √n)`
* **Using Sieve of Eratosthenes:** `O(n log log n)`

---

## 💾 Space Complexity

* **Brute Force:** `O(1)`
* **Using Sieve of Eratosthenes:** `O(n)`

---

## 📚 Concepts Practiced

* Prime Numbers
* Number Theory
* Divisibility
* Brute Force Optimization
* Sieve of Eratosthenes
* Time Complexity Analysis

---

## ✅ Key Takeaway

This problem strengthens the understanding of **prime number generation** and highlights the difference between a simple primality-checking approach and the much more efficient **Sieve of Eratosthenes** for counting primes within a range.
