# Pattern 11

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Patterns, Nested Loops, Alternating Pattern, Basics

---

## ❓ Question

Given an integer `n`, print an alternating binary triangle pattern.

For example, when `n = 5`, the output should be:

```text
1
0 1
1 0 1
0 1 0 1
1 0 1 0 1
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern consists of `n` rows where:

* The number of elements in the `iᵗʰ` row is `i`.
* The values alternate between `1` and `0`.
* Odd-numbered rows start with `1`.
* Even-numbered rows start with `0`.

To generate the pattern:

1. Use an **outer loop** to iterate through each row.
2. Determine the starting value:

   * If the row number is odd, start with `1`.
   * If the row number is even, start with `0`.
3. Use an **inner loop** to print the required number of elements.
4. After printing each element, toggle the value (`1 → 0` or `0 → 1`).
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
1
0 1
1 0 1
0 1 0 1
```

**Explanation**

Odd rows begin with `1`, while even rows begin with `0`. Within each row, the values alternate between `1` and `0`.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
1
0 1
```

**Explanation**

The first row contains a single `1`. The second row starts with `0` and alternates to `1`.

---

## ⏱️ Time Complexity

**O(n²)**

A total of `1 + 2 + ... + n = n(n + 1) / 2` elements are printed, resulting in **O(n²)** time complexity.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Nested loops
* Pattern printing
* Alternating sequences
* Conditional statements
* Modulo operator (`%`)
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem demonstrates how to generate an alternating binary pattern using nested loops. It introduces the idea of determining a row's starting value based on its parity (odd or even) and toggling values during iteration. These concepts are useful in many sequence-generation and pattern-printing problems.
