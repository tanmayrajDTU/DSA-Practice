# Pattern 8

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Patterns, Nested Loops, Pyramids, Basics

---

## ❓ Question

Given an integer `n`, print an inverted centered pyramid pattern of `*` (asterisks).

For example, when `n = 5`, the output should be:

```text
*********
 *******
  *****
   ***
    *
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern consists of:

* `n` rows.
* The first row contains `2 × n - 1` asterisks.
* The number of asterisks decreases by **two** with each row.
* The number of leading spaces increases by **one** with each row, keeping the pattern centered.

For the `iᵗʰ` row (0-based indexing):

* Number of leading spaces = `i`
* Number of asterisks = `2 × (n - i) - 1`

To generate the pattern:

1. Use an **outer loop** to iterate through each row.
2. Print the required number of leading spaces.
3. Print the required number of asterisks.
4. Move to the next line.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 4
```

**Output**

```text
*******
 *****
  ***
   *
```

**Explanation**

The pattern starts with **7** asterisks (`2 × 4 - 1`). Each subsequent row adds one leading space and removes two asterisks, producing an inverted centered pyramid.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
***
 *
```

**Explanation**

The first row contains three asterisks, while the second row contains one asterisk preceded by one leading space.

---

## ⏱️ Time Complexity

**O(n²)**

Each row prints a combination of spaces and asterisks proportional to `n`, resulting in an overall time complexity of **O(n²)**.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Nested loops
* Pattern printing
* Inverted pyramid patterns
* Managing spaces and characters
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem demonstrates how to generate an **inverted centered pyramid** using nested loops. It is the reverse of the standard pyramid pattern and reinforces the concepts of controlling leading spaces and decreasing the number of printed characters. Mastering both normal and inverted pyramids is essential for solving diamond and other complex pattern-printing problems.
