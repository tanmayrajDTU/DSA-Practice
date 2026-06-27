# Return the Largest Digit in a Number

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Math, Number Theory, Loops, Digit Manipulation, Basics

---

## ❓ Question

Given an integer `n`, return the **largest digit** present in the number.

The number contains no leading zeroes, except when the number itself is `0`.

---

## 💡 Approach

Process the number one digit at a time and keep track of the largest digit encountered.

### Steps

1. Handle the special case where `n = 0`. Since the only digit is `0`, return `0`.
2. Initialize a variable `largest` to `0`.
3. While `n` is greater than `0`:

   * Extract the last digit using `n % 10`.
   * Compare it with `largest`.
   * If the current digit is greater, update `largest`.
   * Remove the last digit using integer division (`n /= 10`).
4. Return the value stored in `largest`.

By the end of the loop, `largest` contains the maximum digit present in the number.

---

## 📝 Examples

### Example 1

**Input**

```text id="0j9g7v"
n = 25
```

**Output**

```text id="wjlwmw"
5
```

**Explanation**

The digits are `2` and `5`. The largest digit is `5`.

---

### Example 2

**Input**

```text id="m6ujjq"
n = 99
```

**Output**

```text id="gjscwo"
9
```

**Explanation**

Both digits are `9`, so the largest digit is `9`.

---

### Example 3

**Input**

```text id="5clq9z"
n = 1
```

**Output**

```text id="wclx7w"
1
```

**Explanation**

The number contains only one digit, so it is also the largest digit.

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
* Finding the maximum value
* Number manipulation
* Basic C# syntax

---

## ✅ Key Takeaway

This problem reinforces the technique of **processing a number digit by digit** using the modulus and integer division operators. It demonstrates how to maintain a running maximum while iterating through the digits, a common pattern used in many number manipulation and competitive programming problems.
