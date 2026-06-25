# Sum of First and Last Element in Array

## 📌 Platform

TakeUForward (TUF)

## 🟢 Difficulty

Easy

## 🏷️ Tags

Arrays, Basics

---

## 💡 Approach

The first element of the array is located at index `0`, and the last element is located at index `nums.Length - 1`.

* Access the first element using `nums[0]`.
* Access the last element using `nums[nums.Length - 1]`.
* Return the sum of these two elements.

If the array contains only one element, both indices refer to the same element, so it is added twice.

---

## ⏱️ Time Complexity

**O(1)**

---

## 💾 Space Complexity

**O(1)**

---

## 📚 Concepts Practiced

* Arrays
* Array indexing
* Accessing first and last elements
* Basic arithmetic operations
* Basic C# syntax

---

## ✅ Key Takeaway

This problem reinforces the fundamentals of array indexing by demonstrating how to access the first and last elements directly without traversing the array. It highlights that element access by index is a constant-time operation.
