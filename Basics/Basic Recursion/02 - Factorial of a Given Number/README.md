# ✖️ Factorial of a Given Number

## 📝 Problem Statement

Given an integer `n`, return the **factorial** of `n`.

The factorial of a non-negative integer is the product of all positive integers less than or equal to `n`.

> **Note:** Use a **64-bit integer** to store the answer.

---

## 📖 Examples

### Example 1

**Input**

```text
n = 3
```

**Output**

```text
6
```

**Explanation**

The factorial of `3` is:

```text
1 × 2 × 3 = 6
```

---

### Example 2

**Input**

```text
n = 5
```

**Output**

```text
120
```

**Explanation**

The factorial of `5` is:

```text
1 × 2 × 3 × 4 × 5 = 120
```

---

### Example 3

**Input**

```text
n = 4
```

**Output**

```text
24
```

**Explanation**

The factorial of `4` is:

```text
1 × 2 × 3 × 4 = 24
```

---

## 💡 Approach

This problem can be solved using **recursion**.

* The factorial of a number can be expressed recursively as:

  ```text
  Factorial(n) = n × Factorial(n - 1)
  ```

* Keep reducing the value of `n` by `1` until the **base case** is reached.

* The base case occurs when `n` is `0` or `1`, since:

  ```text
  0! = 1
  1! = 1
  ```

Each recursive call multiplies the current value of `n` with the factorial of the previous number until the recursion terminates at the base case.

---

## ⏱️ Complexity Analysis

| Complexity |    Value |
| ---------- | -------: |
| **Time**   | **O(N)** |
| **Space**  | **O(N)** |

* The recursive function makes one call for each value from `n` down to `1`.
* The recursion stack stores up to `n` function calls, resulting in **O(N)** auxiliary space.
