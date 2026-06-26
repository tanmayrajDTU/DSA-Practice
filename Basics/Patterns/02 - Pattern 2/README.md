# Pattern 2

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Patterns, Nested Loops, Basics

---

## ❓ Question

Given an integer `n`, print a right-angled triangle pattern of `*` (asterisks).

For example, when `n = 5`, the output should be:

```text
*
**
***
****
*****
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern consists of:

* `n` rows.
* The `iᵗʰ` row contains exactly `i` asterisks.

To generate the pattern:

1. Use an **outer loop** to iterate through each row from `1` to `n`.
2. For each row, use an **inner loop** to print asterisks equal to the current row number.
3. Move to the next line after printing each row.

The number of asterisks increases by **one** with every new row.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 4
```

**Output**

```text
*
**
***
****
```

**Explanation**

The pattern contains **4 rows**. Each row prints one more asterisk than the previous row.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
*
**
```

**Explanation**

The first row contains **1** asterisk, and the second row contains **2** asterisks.

---

## ⏱️ Time Complexity

**O(n²)**

A total of `1 + 2 + ... + n = n(n + 1) / 2` asterisks are printed, which is **O(n²)**.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Nested loops
* Pattern printing
* Incremental iteration
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem introduces the concept of generating **incremental patterns** using nested loops. It demonstrates how the outer loop determines the current row, while the inner loop controls the number of characters printed in that row. This pattern forms the foundation for solving more complex triangle and pyramid pattern problems.
