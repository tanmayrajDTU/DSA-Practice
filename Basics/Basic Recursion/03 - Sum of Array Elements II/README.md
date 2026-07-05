# ➕ Sum of Array Elements II

## 📝 Problem Statement

Given an array `nums`, find the **sum of all its elements** using **recursion**.

---

## 📖 Examples

### Example 1

**Input**

```text
nums = [1, 2, 3]
```

**Output**

```text
6
```

**Explanation**

The sum of the array elements is:

```text
1 + 2 + 3 = 6
```

---

### Example 2

**Input**

```text
nums = [5, 8, 1]
```

**Output**

```text
14
```

**Explanation**

The sum of the array elements is:

```text
5 + 8 + 1 = 14
```

---

### Example 3

**Input**

```text
nums = [12, 9, 17]
```

**Output**

```text
38
```

**Explanation**

The sum of the array elements is:

```text
12 + 9 + 17 = 38
```

---

## 💡 Approach

This problem can be solved using **recursion** by processing one array element at a time.

* Start from the first element of the array.
* Add the current element to the sum of the remaining elements.
* Recursively move to the next index until all elements have been processed.
* The **base case** is reached when the current index goes beyond the last element of the array, at which point the function returns `0`.

This way, each recursive call contributes one element to the final sum until the entire array has been traversed.

---

## ⏱️ Complexity Analysis

| Complexity |    Value |
| ---------- | -------: |
| **Time**   | **O(N)** |
| **Space**  | **O(N)** |

* Each array element is visited exactly once.
* The recursion stack stores one function call per element, resulting in **O(N)** auxiliary space.
