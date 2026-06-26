# Pattern 7

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Patterns, Nested Loops, Pyramids, Basics

---

## ❓ Question

Given an integer `n`, print a centered pyramid pattern of `*` (asterisks).

For example, when `n = 5`, the output should be:

```text
    *
   ***
  *****
 *******
*********
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern consists of:

* `n` rows.
* Each row begins with a certain number of **leading spaces**.
* The number of spaces decreases by **one** with each row.
* The number of asterisks increases by **two** with each row, forming a centered pyramid.

For the `iᵗʰ` row (0-based indexing):

* Number of leading spaces = `n - i - 1`
* Number of asterisks = `2 × i + 1`

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
   *
  ***
 *****
*******
```

**Explanation**

The pattern contains **4 rows**. The number of leading spaces decreases by one in each row, while the number of asterisks increases by two, producing a centered pyramid.

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
```

**Explanation**

The first row contains one asterisk with one leading space, while the second row contains three asterisks with no leading spaces.

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
* Pyramid patterns
* Managing spaces and characters
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem introduces **centered pyramid patterns**, where both spaces and characters must be printed in the correct order. It demonstrates how multiple nested loops can work together to control alignment and shape, laying the foundation for solving more advanced pyramid, diamond, and hourglass pattern problems.
