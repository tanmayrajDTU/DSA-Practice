# Pattern 17

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Patterns, Nested Loops, Character Patterns, Pyramid Pattern, Basics

---

## ❓ Question

Given an integer `n`, print a centered alphabet pyramid pattern.

For example, when `n = 5`, the output should be:

```text
    A
   ABA
  ABCBA
 ABCDCBA
ABCDEDCBA
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern consists of `n` rows, where each row has three sections:

1. **Leading spaces** to center the pyramid.
2. **Increasing alphabets** from `A` up to the current row's alphabet.
3. **Decreasing alphabets** back to `A`.

For the `iᵗʰ` row (1-based indexing):

* Print `n - i` leading spaces.
* Print characters from `A` to the `iᵗʰ` alphabet.
* Print characters in reverse order, excluding the peak character to avoid duplication.

To generate the pattern:

1. Use an **outer loop** to iterate through each row.
2. Print the required number of leading spaces.
3. Use one loop to print the increasing alphabet sequence.
4. Use another loop to print the decreasing alphabet sequence.
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
   A
  ABA
 ABCBA
ABCDCBA
```

**Explanation**

Each row forms a palindrome. The alphabets increase from `A` to the current row's character and then decrease symmetrically back to `A`.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
 A
ABA
```

**Explanation**

The first row contains only `A`. The second row prints `A`, `B`, and `A`, forming a symmetric alphabet pattern.

---

## ⏱️ Time Complexity

**O(n²)**

Each row prints spaces and characters proportional to `n`, resulting in an overall time complexity of **O(n²)**.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Nested loops
* Pattern printing
* Character manipulation
* ASCII/Unicode character arithmetic
* Pyramid patterns
* Palindrome patterns
* Managing spaces
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem introduces **palindromic alphabet pyramids**, where each row is symmetric around its center. It combines character arithmetic, nested loops, and spacing logic to build a centered pattern. Breaking the solution into three independent sections—spaces, increasing characters, and decreasing characters—makes complex pattern problems much easier to understand and implement.
