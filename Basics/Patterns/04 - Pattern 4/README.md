# Pattern 4

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Patterns, Nested Loops, Basics

---

## ❓ Question

Given an integer `n`, print a right-angled triangle pattern where each row contains the row number repeated multiple times.

For example, when `n = 5`, the output should be:

```text
1
22
333
4444
55555
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern consists of:

* `n` rows.
* The `iᵗʰ` row contains the number `i` repeated exactly `i` times.

To generate the pattern:

1. Use an **outer loop** to iterate through each row from `1` to `n`.
2. For each row, use an **inner loop** to print the current row number `i`, exactly `i` times.
3. After printing each row, move to the next line.

The value printed changes with each row, while the number of repetitions also increases by one.

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
22
333
4444
```

**Explanation**

Each row prints its row number repeatedly. The first row prints `1` once, the second row prints `2` twice, and so on.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
1
22
```

**Explanation**

The pattern contains two rows. The first row contains one `1`, and the second row contains two `2`s.

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
* Number repetition
* Iteration
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem reinforces the use of nested loops to create number patterns. It demonstrates how the outer loop determines the current row and value, while the inner loop controls how many times that value is printed. Understanding this relationship is essential for solving more advanced pattern-printing problems.
