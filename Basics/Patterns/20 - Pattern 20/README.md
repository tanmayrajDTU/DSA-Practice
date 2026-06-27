# Pattern 20

## 📌 Platform

TakeUForward (TUF)

## 🟡 Difficulty

Medium

## 🏷️ Tags

Patterns, Nested Loops, Butterfly Pattern, Symmetric Patterns

---

## ❓ Question

Given an integer `n`, print the following butterfly star pattern.

For example, when `n = 5`, the output should be:

```text
*        *
**      **
***    ***
****  ****
**********
****  ****
***    ***
**      **
*        *
```

Print the pattern in the function provided.

---

## 💡 Approach

The pattern resembles a **butterfly** and consists of **two symmetric halves**:

1. **Upper Half**
2. **Lower Half**

Each row contains three sections:

* Left block of asterisks (`*`)
* Middle block of spaces
* Right block of asterisks (`*`)

### Upper Half

For the `iᵗʰ` row (1-based indexing):

* Print `i` stars on the left.
* Print `2 × (n - i)` spaces.
* Print `i` stars on the right.

The number of stars increases by one each row, while the spaces decrease by two.

### Lower Half

For the `iᵗʰ` row:

* Print `n - i` stars on the left.
* Print `2 × i` spaces.
* Print `n - i` stars on the right.

The lower half is the mirror image of the upper half.

By combining these two halves, the complete butterfly pattern is formed.

---

## 📝 Examples

### Example 1

**Input**

```text
n = 4
```

**Output**

```text
*      *
**    **
***  ***
********
***  ***
**    **
*      *
```

**Explanation**

The upper half gradually increases the number of stars while decreasing the spaces. The lower half reverses this process, producing a vertically symmetric butterfly pattern.

---

### Example 2

**Input**

```text
n = 2
```

**Output**

```text
*  *
****
*  *
```

**Explanation**

The first row contains one star on each side separated by two spaces. The second row joins both sides together with no spaces, after which the pattern mirrors back.

---

## ⏱️ Time Complexity

**O(n²)**

Each row prints approximately `2 × n` characters, and there are `2 × n - 1` rows. Therefore, the overall time complexity is **O(n²)**.

---

## 💾 Space Complexity

**O(1)**

Only a constant amount of extra space is used.

---

## 📚 Concepts Practiced

* Nested loops
* Butterfly pattern
* Symmetric patterns
* Managing spaces and characters
* Mirror patterns
* Output formatting
* Basic C# syntax

---

## ✅ Key Takeaway

This problem introduces the classic **Butterfly Pattern**, where two mirrored triangles are connected by a dynamically changing gap. It reinforces how complex patterns can be decomposed into independent sections (left stars, spaces, and right stars) and mirrored across an axis. This decomposition strategy is widely applicable to advanced pattern-printing problems.
