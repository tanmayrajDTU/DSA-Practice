# Count All Digits of a Number

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Math, Number Theory, Loops, Basics

---

## ❓ Question

Given an integer `n`, return the total number of digits present in the number.

The number contains no leading zeroes, except when the number itself is `0`.

---

## 💡 Approach

The number of digits can be determined by repeatedly removing the last digit until the number becomes `0`.

To generate the answer:

1. Handle the special case where `n = 0`. Since `0` itself has one digit, return `1`.
2. Initialize a counter to `0`.
3. While `n` is greater than `0`:

   * Remove the last digit using integer division (`n /= 10`).
   * Increment the counter.
4. Return the counter.

Each iteration removes one digit from the number, so the number of iterations equals the number of digits.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 4
```

**Output**

```text
1
```

**Explanation**

The number `4` contains only one digit.

---

### Example 2

**Input**

```text
n = 14
```

**Output**

```text
2
```

**Explanation**

The digits are `1` and `4`, so the total number of digits is `2`.

---

### Example 3

**Input**

```text
n = 234
```

**Output**

```text
3
```

**Explanation**

The number contains three digits: `2`, `3`, and `4`.

---

## ⏱️ Time Complexity

**O(log₁₀ n)**

Each iteration removes one digit by dividing the number by `10`. Therefore, the loop executes once for every digit in the number.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Loops
* Integer division
* Number manipulation
* Counting digits
* Mathematical reasoning
* Basic C# syntax

---

## ✅ Key Takeaway

This problem introduces one of the most fundamental techniques in number manipulation: **repeatedly dividing a number by `10` to process its digits**. This approach forms the basis for many other problems, such as reversing a number, checking for palindromes, summing digits, and extracting individual digits. It is an essential concept in mathematical and algorithmic programming.
