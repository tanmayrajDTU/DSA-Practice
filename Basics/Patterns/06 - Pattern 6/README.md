# Pattern 6

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Patterns, Nested Loops, Basics

---

## ❓ Question

Given an integer `n`, print an inverted right-angled triangle pattern of numbers.

For example, when `n = 5`, the output should be:

```text
12345
1234
123
12
1
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern consists of:

* `n` rows.
* The first row contains numbers from `1` to `n`.
* Each subsequent row contains one fewer number than the previous row.
* The last row contains only `1`.

To generate the pattern:

1. Use an **outer loop** to iterate from `n` down to `1`.
2. For each row, use an **inner loop** to print numbers from `1` to the current row number.
3. After printing each row, move to the next line.

The number of elements decreases by **one** with every new row.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 4
```

**Output**

```text
1234
123
12
1
```

**Explanation**

The pattern starts by printing numbers from `1` to `4`. Each subsequent row removes the last number, resulting in one fewer number per row.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
12
1
```

**Explanation**

The first row prints numbers from `1` to `2`, while the second row prints only `1`.

---

## ⏱️ Time Complexity

**O(n²)**

A total of `n + (n - 1) + ... + 1 = n(n + 1) / 2` numbers are printed, resulting in **O(n²)** time complexity.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Nested loops
* Pattern printing
* Reverse iteration
* Number sequences
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem demonstrates how to generate an inverted number pattern using nested loops. The outer loop controls the number of rows, while the inner loop prints a sequence of numbers that decreases in length with each iteration. It reinforces reverse iteration and sequential number generation, both of which are fundamental concepts for solving more advanced pattern problems.
