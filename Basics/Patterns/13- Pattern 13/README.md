# Pattern 13

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Patterns, Nested Loops, Number Patterns, Basics

---

## ❓ Question

Given an integer `n`, print a triangular pattern of consecutive numbers.

For example, when `n = 5`, the output should be:

```text
1
2 3
4 5 6
7 8 9 10
11 12 13 14 15
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern consists of `n` rows where:

* The `iᵗʰ` row contains exactly `i` numbers.
* Numbers are printed consecutively, starting from `1`.
* A counter variable is used to keep track of the next number to print.

To generate the pattern:

1. Initialize a variable (e.g., `num = 1`).
2. Use an **outer loop** to iterate through each row from `1` to `n`.
3. For each row, use an **inner loop** to print `i` numbers.
4. After printing each number, increment the counter.
5. Move to the next line after completing each row.

Unlike previous number patterns, the values do **not** reset for each row—they continue sequentially.

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
2 3
4 5 6
7 8 9 10
```

**Explanation**

A counter starts from `1` and increases after every number printed. Each row contains one more number than the previous row.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
1
2 3
```

**Explanation**

The first row prints `1`. The second row prints the next two consecutive numbers: `2` and `3`.

---

## ⏱️ Time Complexity

**O(n²)**

A total of `1 + 2 + ... + n = n(n + 1) / 2` numbers are printed, resulting in **O(n²)** time complexity.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Nested loops
* Pattern printing
* Consecutive number generation
* Counter variables
* Iteration
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem introduces the concept of maintaining a **running counter** across multiple rows instead of restarting the sequence for each row. It demonstrates how nested loops and a single incrementing variable can be combined to generate continuous number patterns, a common technique used in many advanced pattern-printing problems.
