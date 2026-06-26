# Pattern 16

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Patterns, Nested Loops, Character Patterns, Basics

---

## ❓ Question

Given an integer `n`, print a right-angled triangle pattern where each row contains the same uppercase English alphabet repeated.

For example, when `n = 5`, the output should be:

```text
A
BB
CCC
DDDD
EEEEE
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern consists of `n` rows where:

* The `iᵗʰ` row contains the `iᵗʰ` uppercase English alphabet.
* The alphabet is repeated exactly `i` times.

For example:

* Row 1 → `A` repeated once.
* Row 2 → `B` repeated twice.
* Row 3 → `C` repeated three times.

To generate the pattern:

1. Use an **outer loop** to iterate through each row from `1` to `n`.
2. Determine the corresponding alphabet using character arithmetic (`'A' + row - 1`).
3. Use an **inner loop** to print that character exactly `row` times.
4. Move to the next line after printing each row.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 4
```

**Output**

```text
A
BB
CCC
DDDD
```

**Explanation**

Each row prints the corresponding alphabet repeated as many times as the row number.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
A
BB
```

**Explanation**

The first row prints `A` once, while the second row prints `B` twice.

---

## ⏱️ Time Complexity

**O(n²)**

A total of `1 + 2 + ... + n = n(n + 1) / 2` characters are printed, resulting in **O(n²)** time complexity.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Nested loops
* Pattern printing
* Character manipulation
* ASCII/Unicode character arithmetic
* Character repetition
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem combines **character arithmetic** with **nested loops** to generate repeated alphabet patterns. It demonstrates how the row number can determine both the character to print and the number of repetitions, a technique frequently used in alphabet-based pattern problems.
