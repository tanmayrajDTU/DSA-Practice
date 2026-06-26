# Pattern 12

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Patterns, Nested Loops, Number Patterns, Basics

---

## ❓ Question

Given an integer `n`, print the following symmetric number pattern.

For example, when `n = 5`, the output should be:

```text
1        1
12      21
123    321
1234  4321
1234554321
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern consists of **three sections** in every row:

1. **Increasing numbers** from `1` to the current row number.
2. **Spaces** between the two number sequences.
3. **Decreasing numbers** from the current row number back to `1`.

For the `iᵗʰ` row (1-based indexing):

* Print numbers from `1` to `i`.
* Print `2 × (n - i)` spaces.
* Print numbers from `i` down to `1`.

As the row number increases:

* The left number sequence grows by one.
* The middle spaces decrease by two.
* The right number sequence mirrors the left sequence.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 4
```

**Output**

```text
1      1
12    21
123  321
12344321
```

**Explanation**

The left half prints numbers in increasing order, the right half prints them in decreasing order, and the spaces between them decrease with each row until both halves meet.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
1  1
1221
```

**Explanation**

The first row contains one number on each side separated by two spaces. In the second row, there are no spaces between the two sequences, producing the final symmetric pattern.

---

## ⏱️ Time Complexity

**O(n²)**

Each row prints numbers and spaces proportional to `n`, resulting in an overall time complexity of **O(n²)**.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Nested loops
* Pattern printing
* Number sequences
* Symmetric patterns
* Managing spaces
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem introduces **symmetric number patterns** by combining increasing and decreasing sequences with dynamically changing spaces. It demonstrates how a complex pattern can be divided into independent sections (left numbers, spaces, and right numbers), making it easier to design and implement similar advanced pattern-printing problems.
