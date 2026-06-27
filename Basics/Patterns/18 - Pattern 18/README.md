# Pattern 18

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Patterns, Nested Loops, Character Patterns, Basics

---

## ❓ Question

Given an integer `n`, print the following alphabet pattern.

For example, when `n = 5`, the output should be:

```text
E
D E
C D E
B C D E
A B C D E
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern consists of `n` rows where:

* The last character of every row is the `nᵗʰ` alphabet (`E` for `n = 5`).
* Each new row starts one alphabet earlier than the previous row.
* Characters are printed in increasing alphabetical order.

For the `iᵗʰ` row (1-based indexing):

* Determine the starting character as `'A' + (n - i)`.
* Print all characters from the starting character up to `'A' + (n - 1)`.

To generate the pattern:

1. Use an **outer loop** to iterate through each row.
2. Compute the starting alphabet for the current row.
3. Use an **inner loop** to print characters from the starting alphabet to the last alphabet.
4. Separate characters with a space (if required by the platform).
5. Move to the next line after each row.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 4
```

**Output**

```text
D
C D
B C D
A B C D
```

**Explanation**

The first row starts with `D`. Each subsequent row begins one alphabet earlier, while always ending with `D`.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
B
A B
```

**Explanation**

The first row prints only `B`. The second row starts from `A` and prints up to `B`.

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
* Character sequences
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem demonstrates how to dynamically determine the starting character of each row while maintaining an increasing alphabetical sequence. It reinforces character arithmetic and nested loop logic, showing that pattern generation often depends on computing the correct starting point rather than printing a fixed sequence.
