# Pattern 19

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Patterns, Nested Loops, Symmetric Patterns, Basics

---

## ❓ Question

Given an integer `n`, print the following symmetric star pattern.

For example, when `n = 5`, the output should be:

```text
**********
****  ****
***    ***
**      **
*        *
*        *
**      **
***    ***
****  ****
**********
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern consists of **two symmetric halves**:

1. **Upper Half**
2. **Lower Half**

Each row is divided into **three sections**:

* Left block of asterisks (`*`)
* Middle block of spaces
* Right block of asterisks (`*`)

### Upper Half

For each row:

* The number of asterisks on both sides decreases by **one**.
* The number of spaces in the middle increases by **two**.

### Lower Half

For each row:

* The number of asterisks on both sides increases by **one**.
* The number of spaces in the middle decreases by **two**.

To generate the pattern:

1. Print the upper half using nested loops.
2. Print the lower half using another set of nested loops.
3. In each row:

   * Print the left stars.
   * Print the middle spaces.
   * Print the right stars.
4. Move to the next line after each row.

Breaking the pattern into two independent halves makes the implementation straightforward and easy to understand.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 4
```

**Output**

```text
********
***  ***
**    **
*      *
*      *
**    **
***  ***
********
```

**Explanation**

The upper half gradually decreases the number of stars while increasing the spaces. The lower half mirrors this behavior, creating a horizontally symmetric pattern.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
****
*  *
*  *
****
```

**Explanation**

The pattern consists of two rows in the upper half and two mirrored rows in the lower half, forming the required symmetric shape.

---

## ⏱️ Time Complexity

**O(n²)**

Each row prints approximately `2 × n` characters, and there are `2 × n` rows, resulting in an overall time complexity of **O(n²)**.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Nested loops
* Pattern printing
* Symmetric patterns
* Managing spaces and characters
* Mirror patterns
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem demonstrates how complex symmetric patterns can be constructed by dividing them into **upper** and **lower** halves. Each row is further composed of three independent sections—left stars, middle spaces, and right stars. Mastering this decomposition technique is essential for solving advanced butterfly, hourglass, and hollow pattern problems.
