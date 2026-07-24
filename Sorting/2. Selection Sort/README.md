# Selection Sort

## 📝 Problem Statement for Selection Sort

Given an integer array `nums`, sort the array in **non-decreasing order** using the **Selection Sort** algorithm and return the sorted array.

A non-decreasing order means every element is greater than or equal to the previous element.

---

## 📌 Examples

### Example 1

**Input**
```text
nums = [7, 4, 1, 5, 3]
```

**Output**
```text
[1, 3, 4, 5, 7]
```

---

### Example 2

**Input**
```text
nums = [5, 4, 4, 1, 1]
```

**Output**
```text
[1, 1, 4, 4, 5]
```

---

### Example 3

**Input**
```text
nums = [3, 2, 3, 4, 5]
```

**Output**
```text
[2, 3, 3, 4, 5]
```

---

## 💡 Approach

Selection Sort divides the array into two parts:

- **Sorted portion** (left side)
- **Unsorted portion** (right side)

In every iteration:

1. Find the smallest element in the unsorted portion.
2. Swap it with the first element of the unsorted portion.
3. Expand the sorted portion by one element.

Unlike Bubble Sort, Selection Sort performs **only one swap per iteration**.

---

## 🔄 Algorithm

1. Start from index `0`.
2. Assume the current element is the minimum.
3. Traverse the remaining unsorted array to find the actual minimum element.
4. Swap the minimum element with the current position.
5. Repeat until the entire array is sorted.

---

## 🔄 Dry Run

Array:
```text
[7, 4, 1, 5, 3]
```

### Pass 1

Minimum = **1**

```
[7, 4, 1, 5, 3]
        ↑

Swap 7 and 1

[1, 4, 7, 5, 3]
```

---

### Pass 2

Minimum = **3**

```
[1, 4, 7, 5, 3]
             ↑

Swap 4 and 3

[1, 3, 7, 5, 4]
```

---

### Pass 3

Minimum = **4**

```
[1, 3, 7, 5, 4]
             ↑

Swap 7 and 4

[1, 3, 4, 5, 7]
```

---

### Pass 4

Minimum = **5**

Already in correct position.

---

Final Array

```text
[1, 3, 4, 5, 7]
```

---

## ⏱️ Complexity Analysis

| Case | Time Complexity |
|------|-----------------|
| Best | **O(n²)** |
| Average | **O(n²)** |
| Worst | **O(n²)** |

**Space Complexity:** `O(1)`

---

## 📊 Number of Operations

- Comparisons: **O(n²)**
- Swaps: **O(n)**

Selection Sort performs the minimum possible number of swaps among simple sorting algorithms.

---

## ✅ Characteristics

- In-place sorting algorithm
- Not stable (default implementation)
- Simple implementation
- Performs fewer swaps than Bubble Sort
- Not adaptive (does not benefit from an already sorted array)

---

## ❓ Frequently Asked Questions

### Can Selection Sort handle duplicate elements?

Yes, it correctly sorts arrays containing duplicate values.

However, the standard implementation is **not stable**, meaning duplicate elements may not retain their original relative order after sorting.

---

### What happens if the array is already sorted?

Selection Sort still scans the remaining unsorted portion during every iteration to verify the smallest element.

Therefore, its time complexity remains **O(n²)** even for an already sorted array.

---

## 🎯 Interview Follow-ups

### Can Selection Sort be made stable?

Yes.

Instead of swapping the minimum element with the current position, shift the elements between them by one position and insert the minimum element at its correct place.

This preserves the relative order of equal elements but increases the number of element movements.

---

### Selection Sort vs Bubble Sort vs Insertion Sort

| Feature | Selection Sort | Bubble Sort | Insertion Sort |
|----------|---------------|------------|---------------|
| Best Time | O(n²) | O(n) (optimized) | O(n) |
| Average Time | O(n²) | O(n²) | O(n²) |
| Worst Time | O(n²) | O(n²) | O(n²) |
| Stable | ❌ No | ✅ Yes | ✅ Yes |
| In-place | ✅ Yes | ✅ Yes | ✅ Yes |
| Adaptive | ❌ No | ✅ Yes | ✅ Yes |
| Swaps | **O(n)** | O(n²) | O(n²) (shifts) |

---

## 📚 Key Takeaways

- Selection Sort repeatedly selects the **smallest element** from the unsorted portion and places it in its correct position.
- It always performs **O(n²)** comparisons regardless of input order.
- It requires only **O(n)** swaps, making it useful when swaps are expensive.
- It is simple to implement but generally less efficient than Insertion Sort for nearly sorted data.
- Standard Selection Sort is **not stable**, though a stable variant can be implemented easily.
