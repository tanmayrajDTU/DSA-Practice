# Pattern 1

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Patterns, Nested Loops, Basics

---

## ❓ Question

Given an integer `n`, print a square pattern of `*` (asterisks) having `n` rows and `n` columns.

For example, when `n = 5`, the output should be:

```text
*****
*****
*****
*****
*****
```

Print the pattern in the function provided.

---

## 💡 Approach

A square pattern consists of:

* `n` rows.
* Each row contains exactly `n` asterisks (`*`).

To generate the pattern:

1. Use an **outer loop** to iterate through each row.
2. For every row, use an **inner loop** to print `n` asterisks.
3. After printing one row, move to the next line.

This is a classic application of **nested loops**, where:

* The outer loop controls the number of rows.
* The inner loop controls the number of columns.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 4
```

**Output**

```text
****
****
****
****
```

**Explanation**

The pattern contains **4 rows**, and each row contains **4 asterisks**, forming a `4 × 4` square.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
**
**
```

**Explanation**

The pattern contains **2 rows**, and each row contains **2 asterisks**, forming a `2 × 2` square.

---

## ⏱️ Time Complexity

**O(n²)**

The outer loop runs `n` times, and for each iteration, the inner loop also runs `n` times.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Nested loops
* Pattern printing
* Iteration
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem introduces the fundamentals of **pattern printing** using nested loops. Understanding how the outer loop controls rows and the inner loop controls columns is essential, as the same concept is used to solve more advanced pattern problems.
