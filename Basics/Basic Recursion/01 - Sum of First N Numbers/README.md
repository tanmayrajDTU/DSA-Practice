# ➕ Sum of First N Numbers

## 📝 Problem Statement

Given an integer `N`, return the **sum of the first `N` natural numbers**.

Try to solve the problem using **recursion**.

---

## 📖 Examples

### Example 1

**Input**

```text
N = 4
```

**Output**

```text
10
```

**Explanation**

The first four natural numbers are `1, 2, 3, 4`.

Their sum is:

```text
1 + 2 + 3 + 4 = 10
```

---

### Example 2

**Input**

```text
N = 2
```

**Output**

```text
3
```

**Explanation**

The first two natural numbers are `1` and `2`.

Their sum is:

```text
1 + 2 = 3
```

---

### Example 3

**Input**

```text
N = 10
```

**Output**

```text
55
```

**Explanation**

The sum of the first ten natural numbers is:

```text
1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 = 55
```

---

## 💡 Approach

The problem can be solved using **recursion** by breaking it into smaller subproblems.

* The sum of the first `N` natural numbers can be expressed as:

  ```text
  Sum(N) = N + Sum(N - 1)
  ```

* Continue reducing the value of `N` until it reaches the **base case**.

* The base case occurs when `N = 1`, since the sum of the first natural number is simply `1`.

The recursive function keeps adding the current value of `N` to the sum of the remaining natural numbers until the base case is reached.

---

## ⏱️ Complexity Analysis

| Complexity |    Value |
| ---------- | -------: |
| **Time**   | **O(N)** |
| **Space**  | **O(N)** |

* The recursive function makes one call for each value from `N` down to `1`.
* The recursion stack stores `N` function calls, resulting in **O(N)** auxiliary space.
