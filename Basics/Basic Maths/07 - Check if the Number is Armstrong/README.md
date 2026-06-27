# Check if the Number is Armstrong

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Math, Number Theory, Loops, Digit Manipulation, Armstrong Number

---

## ❓ Question

Given an integer `n`, determine whether it is an **Armstrong number**.

An Armstrong number is a number that is equal to the **sum of each of its digits raised to the power of the total number of digits**.

Return:

* `true` if `n` is an Armstrong number.
* `false` otherwise.

---

## 💡 Approach

To determine whether a number is an Armstrong number:

### Steps

1. Store the original number in a temporary variable.
2. Count the total number of digits in the number.
3. Process the number digit by digit:

   * Extract the last digit using `n % 10`.
   * Raise the digit to the power of the total number of digits.
   * Add the result to a running sum.
   * Remove the last digit using integer division (`n /= 10`).
4. Compare the computed sum with the original number.
5. If both are equal, return `true`; otherwise, return `false`.

> **Note:** The number `0` is also an Armstrong number because:
>
> ```text
> 0¹ = 0
> ```

---

## 📝 Examples

### Example 1

**Input**

```text
n = 153
```

**Output**

```text
true
```

**Explanation**

The number contains **3** digits.

```text
1³ + 5³ + 3³
= 1 + 125 + 27
= 153
```

Since the computed sum equals the original number, `153` is an Armstrong number.

---

### Example 2

**Input**

```text
n = 12
```

**Output**

```text
false
```

**Explanation**

The number contains **2** digits.

```text
1² + 2²
= 1 + 4
= 5
```

Since `5 ≠ 12`, the number is **not** an Armstrong number.

---

### Example 3

**Input**

```text
n = 370
```

**Output**

```text
true
```

**Explanation**

The number contains **3** digits.

```text
3³ + 7³ + 0³
= 27 + 343 + 0
= 370
```

Since the computed sum equals the original number, `370` is an Armstrong number.

---

## ⏱️ Time Complexity

**O(d)**

Where **`d`** is the number of digits in the number.

The algorithm performs two passes over the digits:

* One to count the digits.
* One to compute the Armstrong sum.

Since `d = log₁₀(n) + 1`, the complexity can also be written as **O(log₁₀ n)**.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Loops
* Digit extraction
* Integer division
* Modulus operator (`%`)
* Exponentiation
* Number manipulation
* Mathematical reasoning
* Basic C# syntax

---

## ✅ Key Takeaway

This problem combines several fundamental number manipulation techniques: **counting digits, extracting digits, exponentiation, and accumulation**. Unlike simpler digit-processing problems, the solution requires **multiple passes over the number** and demonstrates how different mathematical operations can be combined to solve a classification problem. Armstrong numbers are a classic interview topic and provide excellent practice for digit-based algorithms.
