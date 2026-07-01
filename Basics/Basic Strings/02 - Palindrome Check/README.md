# 🔍 Palindrome Check

## 📝 Problem Statement

Given a string `s`, determine whether it is a **palindrome**.

A string is called a palindrome if it reads the same **forward** and **backward**.

Return:

* `true` if the string is a palindrome.
* `false` otherwise.

---

## 📖 Examples

### Example 1

**Input**

```text
s = "hannah"
```

**Output**

```text
true
```

**Explanation**

Reading the string from left to right and right to left gives the same result (`"hannah"`). Therefore, it is a palindrome.

---

### Example 2

**Input**

```text
s = "aabbaaa"
```

**Output**

```text
false
```

**Explanation**

The reversed string is `"aaabbaa"`, which is different from the original string. Hence, it is not a palindrome.

---

### Example 3

**Input**

```text
s = "aabbccbbaa"
```

**Output**

```text
true
```

**Explanation**

The string reads the same in both directions, making it a palindrome.

---

## 💡 Approach

This problem can be solved efficiently using the **Two Pointers** technique.

* Place one pointer at the **beginning** of the string and another at the **end**.
* Compare the characters at both pointers.
* If the characters are different, the string is **not** a palindrome, so return `false`.
* If they match, move the left pointer one step forward and the right pointer one step backward.
* Continue until the pointers meet or cross.

If all corresponding characters match, the string is a palindrome.

---

## ⏱️ Complexity Analysis

| Complexity |    Value |
| ---------- | -------: |
| **Time**   | **O(n)** |
| **Space**  | **O(1)** |

* Each character is compared at most once.
* No extra data structures are used.
