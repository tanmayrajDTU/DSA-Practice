# Pattern 3

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Patterns, Nested Loops, Basics

---

## ❓ Question

Given an integer `n`, print a right-angled triangle pattern of numbers.

For example, when `n = 5`, the output should be:

```text
1
12
123
1234
12345
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern consists of:

* `n` rows.
* The `iᵗʰ` row contains numbers from `1` to `i`.

To generate the pattern:

1. Use an **outer loop** to iterate through each row from `1` to `n`.
2. For each row, use an **inner loop** to print numbers starting from `1` up to the current row number.
3. After printing all numbers in a row, move to the next line.

The number of elements increases by **one** with each successive row.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 4
```

**Output**

```text
1
12
123
1234
```

**Explanation**

The pattern contains **4 rows**. Each row prints numbers sequentially from `1` to the current row number.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
1
12
```

**Explanation**

The first row contains only `1`, while the second row contains numbers from `1` to `2`.

---

## ⏱️ Time Complexity

**O(n²)**

A total of `1 + 2 + ... + n = n(n + 1) / 2` numbers are printed, which is **O(n²)**.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Nested loops
* Pattern printing
* Number sequences
* Iteration
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem demonstrates how nested loops can be used to generate numeric patterns. The outer loop determines the current row, while the inner loop prints a sequence of numbers up to the row number. This concept is fundamental for solving more advanced number pattern problems.
