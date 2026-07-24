# Bubble Sort

## 📝 Problem Statement for Bubble Sort

Given an integer array `nums`, sort the array in **non-decreasing order** using the **Bubble Sort** algorithm and return the sorted array.

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

Bubble Sort repeatedly compares adjacent elements and swaps them if they are in the wrong order.

After every pass, the largest unsorted element "bubbles up" to its correct position at the end of the array.

### Algorithm

1. Traverse the array multiple times.
2. Compare every pair of adjacent elements.
3. Swap them if the left element is greater than the right.
4. After each pass, the largest remaining element reaches its correct position.
5. Repeat until the array becomes sorted.
6. An optimization is to stop early if no swaps occur during a pass.

---

## 🔄 Dry Run

Array:
```text
[7, 4, 1, 5, 3]
```

### Pass 1
```
7 4 → swap
4 7 1 5 3

7 1 → swap
4 1 7 5 3

7 5 → swap
4 1 5 7 3

7 3 → swap
4 1 5 3 7
```

### Pass 2
```
4 1 → swap
1 4 5 3 7

4 5 → no swap

5 3 → swap
1 4 3 5 7
```

### Pass 3
```
1 4 → no swap

4 3 → swap
1 3 4 5 7
```

### Pass 4
```
Already sorted
```

Final Array:
```text
[1, 3, 4, 5, 7]
```

---

## ⏱️ Complexity Analysis

| Case | Time Complexity |
|------|-----------------|
| Best (Optimized) | **O(n)** |
| Average | **O(n²)** |
| Worst | **O(n²)** |

**Space Complexity:** `O(1)`

---

## ✅ Characteristics

- Stable sorting algorithm
- In-place sorting
- Easy to understand and implement
- Inefficient for large datasets

---

## ❓ Frequently Asked Questions

### Can Bubble Sort handle duplicate elements?

Yes. Bubble Sort is a **stable sorting algorithm**, meaning duplicate elements retain their original relative order.

### What happens if the array is already sorted?

Without optimization, Bubble Sort still performs all passes (`O(n²)`).

With a swap flag optimization, it terminates after one pass, giving **O(n)** time complexity.

### What happens if the array is reverse sorted?

This is the worst-case scenario. Every adjacent pair requires swapping, resulting in **O(n²)** time complexity.

---

## 🎯 Interview Follow-ups

### Can Bubble Sort sort in descending order?

Yes. Simply swap when the left element is **smaller** than the right element instead of greater.

### Bubble Sort vs Selection Sort vs Insertion Sort

| Feature | Bubble Sort | Selection Sort | Insertion Sort |
|----------|------------|---------------|---------------|
| Best Time | O(n) (optimized) | O(n²) | O(n) |
| Average Time | O(n²) | O(n²) | O(n²) |
| Worst Time | O(n²) | O(n²) | O(n²) |
| Stable | ✅ Yes | ❌ No | ✅ Yes |
| In-place | ✅ Yes | ✅ Yes | ✅ Yes |
| Adaptive | ✅ Yes (optimized) | ❌ No | ✅ Yes |

---

## 📚 Key Takeaways

- Bubble Sort repeatedly swaps adjacent elements until the array is sorted.
- The largest element reaches its correct position after each pass.
- Early termination optimization improves the best-case complexity to **O(n)**.
- Although simple, Bubble Sort is generally not preferred for large datasets due to its **O(n²)** average and worst-case performance.
