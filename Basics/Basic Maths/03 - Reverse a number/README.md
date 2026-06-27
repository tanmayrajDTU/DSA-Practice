# Reverse a Number

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Math, Number Theory, Loops, Digit Manipulation, Basics

---

## ❓ Question

Given an integer `n`, return the integer formed by reversing the digits of `n`.

The number contains no leading zeroes, except when the number itself is `0`.

---

## 💡 Approach

The reversed number can be constructed by extracting digits from right to left and appending them to a new number.

### Steps

1. Initialize a variable `reverse` to `0`.
2. While `n` is greater than `0`:

   * Extract the last digit using `n % 10`.
   * Append it to the reversed number using:

     ```text
     reverse = reverse × 10 + digit
     ```
   * Remove the last digit using integer division (`n /= 10`).
3. Return the value of `reverse`.

> **Note:** If `n = 0`, the loop does not execute, and the result remains `0`, which is the correct reversed value.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 25
```

**Output**

```text
52
```

**Explanation**

The digits are extracted in the order `5` and `2`, forming the reversed number `52`.

---

### Example 2

**Input**

```text
n = 123
```

**Output**

```text
321
```

**Explanation**

The digits are extracted from right to left (`3`, `2`, `1`) and appended to form `321`.

---

### Example 3

**Input**

```text
n = 54
```

**Output**

```text
45
```

**Explanation**

The digits `5` and `4` are reversed, resulting in `45`.

---

## ⏱️ Time Complexity

**O(log₁₀ n)**

The algorithm processes one digit during each iteration. Therefore, the number of iterations equals the number of digits in the input.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Loops
* Modulus operator (`%`)
* Integer division
* Digit extraction
* Number reconstruction
* Number manipulation
* Basic C# syntax

---

## ✅ Key Takeaway

This problem introduces the standard technique for **reversing an integer** using digit extraction and reconstruction. The expression `reverse = reverse × 10 + digit` is a fundamental pattern that appears in many number-based algorithms, including palindrome checks, Armstrong numbers, and other digit manipulation problems. Mastering this technique is essential for solving a wide range of mathematical programming questions.
