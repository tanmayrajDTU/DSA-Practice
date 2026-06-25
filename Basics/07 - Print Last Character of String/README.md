# Print Last Character of String

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Strings, Basics

---

## 💡 Approach

The last character of a string can be accessed using its last index.

* Find the length of the string.
* The last character is located at index `Length - 1`.
* Return or print the character at that index.

Since accessing a character by index is a constant-time operation, no traversal of the string is required.

---

## 📝 Examples

### Example 1

**Input**

```text
s = "takeuforward"
```

**Output**

```text
d
```

**Explanation**

The string has 12 characters. The last character is **'d'**, which is returned.

---

### Example 2

**Input**

```text
s = "goodforyou"
```

**Output**

```text
u
```

**Explanation**

The last character of the string is **'u'**.

---

### Example 3

**Input**

```text
s = "lovecoding"
```

**Output**

```text
g
```

**Explanation**

The last character of the string is **'g'**.

---

## ⏱️ Time Complexity

**O(1)**

---

## 💾 Space Complexity

**O(1)**

---

## 📚 Concepts Practiced

* Strings
* String indexing
* Accessing characters
* Basic C# syntax

---

## ✅ Key Takeaway

This problem reinforces how strings are indexed and demonstrates how to access the last character efficiently using `Length - 1`. Understanding string indexing is fundamental for solving more advanced string manipulation problems.
