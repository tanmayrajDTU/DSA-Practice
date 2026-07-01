# 🔄 Reverse a String II

## 📝 Problem Statement

Given a string represented as an array of characters `s`, reverse the array **in-place**.

The reversal must be performed using **O(1)** extra memory, meaning no additional array or string should be created.

> **Note:** Do not return anything. Modify the given character array directly.

---

## 📖 Examples

### Example 1

**Input**

```text
s = ['h', 'e', 'l', 'l', 'o']
```

**Output**

```text
['o', 'l', 'l', 'e', 'h']
```

**Explanation**

The string `"hello"` is reversed to `"olleh"` by swapping characters from both ends.

---

### Example 2

**Input**

```text
s = ['b', 'y', 'e']
```

**Output**

```text
['e', 'y', 'b']
```

**Explanation**

The string `"bye"` becomes `"eyb"` after reversing.

---

### Example 3

**Input**

```text
s = ['h', 'a', 'n', 'n', 'a', 'h']
```

**Output**

```text
['h', 'a', 'n', 'n', 'a', 'h']
```

**Explanation**

The string is a palindrome, so it remains unchanged after reversal.

---

## 💡 Approach

This problem can be solved efficiently using the **Two Pointers** technique.

* Place one pointer at the **beginning** of the array and another at the **end**.
* Swap the characters at these two positions.
* Move the left pointer one step forward and the right pointer one step backward.
* Repeat this process until the two pointers meet or cross.

Since characters are swapped within the same array, the reversal is performed **in-place**, satisfying the **O(1)** extra space requirement.

---

## ⏱️ Complexity Analysis

| Complexity |    Value |
| ---------- | -------: |
| **Time**   | **O(n)** |
| **Space**  | **O(1)** |

* Each character is processed at most once.
* No additional data structures are used.
