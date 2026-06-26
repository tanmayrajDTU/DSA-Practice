# Pattern 15

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Patterns, Nested Loops, Character Patterns, Basics

---

## ❓ Question

Given an integer `n`, print an inverted right-angled triangle pattern of uppercase English alphabets.

For example, when `n = 5`, the output should be:

```text
ABCDE
ABCD
ABC
AB
A
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern consists of `n` rows where:

* The first row contains the first `n` uppercase English alphabets.
* Each subsequent row contains one fewer alphabet than the previous row.
* Every row always starts with **'A'**.

To generate the pattern:

1. Use an **outer loop** to iterate from `n` down to `1`.
2. For each row, use an **inner loop** to print characters from **'A'** up to the required character.
3. Convert the loop index to its corresponding character using character arithmetic.
4. Move to the next line after printing each row.

The number of printed characters decreases by one with each row.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 4
```

**Output**

```text
ABCD
ABC
AB
A
```

**Explanation**

The first row prints the first four alphabets. Each subsequent row removes the last character, forming an inverted alphabet triangle.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
AB
A
```

**Explanation**

The first row prints **A** and **B**, while the second row prints only **A**.

---

## ⏱️ Time Complexity

**O(n²)**

A total of `n + (n - 1) + ... + 1 = n(n + 1) / 2` characters are printed, resulting in **O(n²)** time complexity.

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
* Reverse iteration
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem is the inverse of the increasing alphabet triangle. It reinforces reverse iteration with nested loops while demonstrating how character arithmetic can be used to generate alphabet sequences. Mastering both increasing and decreasing character patterns provides a strong foundation for solving more advanced alphabet-based pattern problems.
