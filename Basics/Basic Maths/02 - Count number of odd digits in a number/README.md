# Count Number of Odd Digits in a Number

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Math, Number Theory, Loops, Digit Manipulation, Basics

---

## ❓ Question

Given an integer `n`, return the number of **odd digits** present in the number.

The number contains no leading zeroes, except when the number itself is `0`.

---

## 💡 Approach

To count the odd digits, process the number one digit at a time.

### Steps

1. Initialize a counter to `0`.
2. While `n` is greater than `0`:

   * Extract the last digit using the modulus operator (`n % 10`).
   * Check whether the digit is odd using `digit % 2 != 0`.
   * If it is odd, increment the counter.
   * Remove the last digit using integer division (`n /= 10`).
3. Return the counter.

> **Note:** If `n = 0`, the answer is `0` because `0` is an even digit.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 5
```

**Output**

```text
1
```

**Explanation**

The number contains a single digit, `5`, which is odd. Therefore, the answer is `1`.

---

### Example 2

**Input**

```text
n = 25
```

**Output**

```text
1
```

**Explanation**

The digits are `2` and `5`. Only `5` is odd, so the answer is `1`.

---

### Example 3

**Input**

```text
n = 15
```

**Output**

```text
2
```

**Explanation**

Both digits (`1` and `5`) are odd, so the answer is `2`.

---

## ⏱️ Time Complexity

**O(log₁₀ n)**

The algorithm processes one digit per iteration. Therefore, the number of iterations equals the number of digits in the input.

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
* Odd and even number checking
* Number manipulation
* Basic C# syntax

---

## ✅ Key Takeaway

This problem reinforces the fundamental technique of **digit extraction** using the modulus (`%`) and integer division (`/`) operators. Processing numbers digit by digit is a core concept that appears in many mathematical and algorithmic problems, including digit sums, palindrome numbers, Armstrong numbers, and digit frequency counting.
