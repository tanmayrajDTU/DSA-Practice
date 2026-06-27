# Palindrome Number

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Math, Number Theory, Loops, Digit Manipulation, Palindrome, Basics

---

## ❓ Question

Given an integer `n`, determine whether it is a **palindrome number**.

A palindrome number reads the same from **left to right** and **right to left**.

Return:

* `true` if the number is a palindrome.
* `false` otherwise.

---

## 💡 Approach

A straightforward approach is to reverse the given number and compare it with the original number.

### Steps

1. Store the original value of `n` in a temporary variable.
2. Initialize a variable `reverse` to `0`.
3. While `n` is greater than `0`:

   * Extract the last digit using `n % 10`.
   * Append it to the reversed number:

     ```text
     reverse = reverse × 10 + digit
     ```
   * Remove the last digit using integer division (`n /= 10`).
4. Compare the reversed number with the original number.
5. If both are equal, return `true`; otherwise, return `false`.

> **Note:** The number `0` is also a palindrome because reversing it still results in `0`.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 121
```

**Output**

```text
true
```

**Explanation**

Original number: `121`

Reversed number: `121`

Since both are equal, the number is a palindrome.

---

### Example 2

**Input**

```text
n = 123
```

**Output**

```text
false
```

**Explanation**

Original number: `123`

Reversed number: `321`

Since the numbers are different, it is not a palindrome.

---

### Example 3

**Input**

```text
n = 101
```

**Output**

```text
true
```

**Explanation**

Reversing `101` produces `101`, so the number is a palindrome.

---

## ⏱️ Time Complexity

**O(log₁₀ n)**

The algorithm processes each digit exactly once while reversing the number.

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
* Number reversal
* Number comparison
* Palindrome checking
* Basic C# syntax

---

## ✅ Key Takeaway

This problem combines two fundamental concepts: **reversing a number** and **comparing values**. It demonstrates how digit extraction and reconstruction can be used to solve palindrome-related problems efficiently without converting the number into a string. This technique serves as the foundation for many number manipulation problems encountered in coding interviews.
