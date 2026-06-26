# Pattern 9

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Patterns, Nested Loops, Pyramids, Diamond Pattern, Basics

---

## ❓ Question

Given an integer `n`, print a diamond pattern of `*` (asterisks).

For example, when `n = 5`, the output should be:

```text
    *
   ***
  *****
 *******
*********
*********
 *******
  *****
   ***
    *
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern consists of **two centered pyramids**:

1. An **upright pyramid**.
2. An **inverted pyramid**.

### Upper Half

For each row:

* Print `n - i - 1` leading spaces.
* Print `2 × i + 1` asterisks.

### Lower Half

For each row:

* Print `i` leading spaces.
* Print `2 × (n - i) - 1` asterisks.

By printing these two patterns consecutively, a complete diamond shape is formed.

> **Note:** In this version of the pattern, the middle row is printed **twice**, once as the last row of the upper pyramid and once as the first row of the inverted pyramid.

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
  ***
 *****
*******
*******
 *****
  ***
   *
```

**Explanation**

The output consists of an upright pyramid followed immediately by an inverted pyramid. The widest row (`*******`) appears twice, creating the required pattern.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
 *
***
***
 *
```

**Explanation**

The upper pyramid prints one and three asterisks, followed by the inverted pyramid starting again with three asterisks.

---

## ⏱️ Time Complexity

**O(n²)**

Each half of the pattern requires nested loops that print spaces and asterisks proportional to `n`. The overall complexity remains **O(n²)**.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Nested loops
* Pattern printing
* Pyramid patterns
* Inverted pyramid patterns
* Diamond patterns
* Managing spaces and characters
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem combines two previously learned patterns—an upright pyramid and an inverted pyramid—to create a complete diamond. It reinforces the idea that complex patterns can often be built by composing simpler ones, an important technique for tackling advanced pattern-printing problems.
