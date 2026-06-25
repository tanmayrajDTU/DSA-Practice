# Print X N Numbers of Times

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Loops, Basics

---

## 💡 Approach

Use a `for` loop to print the value `X` exactly `N` times.

* Iterate from `0` to `N - 1`.
* Print `X` during each iteration.
* Print a space only if the current iteration is **not** the last one to avoid a trailing space.
* After the loop, print a newline.
* If `N` is `0`, the loop is skipped and only an empty line is printed.

---

## 📝 Examples

### Example 1

**Input**

```text
X = 7
N = 5
```

**Output**

```text
7 7 7 7 7
```

**Explanation**

The loop executes **5** times, printing the value **7** during each iteration.

---

### Example 2

**Input**

```text
X = 15
N = 1
```

**Output**

```text
15
```

**Explanation**

Since `N = 1`, the loop executes only once.

---

### Example 3

**Input**

```text
X = -5
N = 4
```

**Output**

```text
-5 -5 -5 -5
```

**Explanation**

The value **-5** is printed **4** times with a single space separating consecutive values.

---

## ⏱️ Time Complexity

**O(N)**

---

## 💾 Space Complexity

**O(1)**

---

## 📚 Concepts Practiced

* `for` loop
* Iteration
* Output formatting
* Conditional statements
* Basic C# syntax

---

## ✅ Key Takeaway

This problem reinforces the use of loops to perform repetitive tasks while maintaining proper output formatting. It also highlights handling edge cases, such as avoiding trailing spaces and printing an empty line when `N = 0`.
