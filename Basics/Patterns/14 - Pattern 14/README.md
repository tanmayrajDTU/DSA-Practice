# Pattern 14

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Patterns, Nested Loops, Character Patterns, Basics

---

## ❓ Question

Given an integer `n`, print a right-angled triangle pattern of uppercase English alphabets.

For example, when `n = 5`, the output should be:

```text
A
AB
ABC
ABCD
ABCDE
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern consists of `n` rows where:

* The `iᵗʰ` row contains the first `i` uppercase English alphabets.
* Every row always starts with **'A'**.
* Characters are printed sequentially up to the current row.

To generate the pattern:

1. Use an **outer loop** to iterate through each row from `1` to `n`.
2. For each row, use an **inner loop** to iterate from `0` to `i - 1`.
3. Convert the loop index to its corresponding character by adding it to `'A'`.
4. Print the generated character.
5. Move to the next line after completing each row.

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
AB
ABC
ABCD
```

**Explanation**

Each row starts from **A** and prints one additional alphabet compared to the previous row.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
A
AB
```

**Explanation**

The first row contains only **A**, while the second row contains **A** followed by **B**.

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
* Iteration
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem demonstrates how characters can be generated programmatically using character arithmetic. It reinforces the use of nested loops while introducing alphabet-based patterns, which are a natural extension of number patterns and are commonly encountered in pattern-printing exercises.
