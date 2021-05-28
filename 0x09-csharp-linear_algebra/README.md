# Linear Algebra
This project is an introduction to linear algebra and its concepts. Linear algebra is essential to computer graphics and will give me a better understanding of what’s going on under the hood of game and graphics engines.

## Quiz questions

**Question #0**  
In linear algebra, a vector is defined by:

✔️ Magnitude and direction  
❌ Speed and direction  
❌ Position and magnitude  

**Question #1**  
A vector has a specific starting position.

❌ True  
✔️ False  

**Question #2**  
A scalar is:

❌ A quarternion  
❌ A weighted average  
✔️ A real number  

**Question #3**  
Dot product is:

❌ The result of multiplying two vectors together  
✔️ A scalar representation of two vectors  
❌ A vector’s position  

**Question #4**  
What does it mean if the dot product of two vectors is 0?

✔️ The vectors are perpendicular  
❌ The dot product is unable to be calculated  
❌ The vectors are parallel  

**Question #5**  
Cross product is:

✔️ The result of multiplying two vectors together  
❌ Two vectors that intersect each other  
✔️ A vector that is perpendicular to two given vectors  

**Question #6**  
What does it mean if the cross product of two vectors is 0?

the vectors are parallel  
✔️ One or both of the vectors is a zero vector  
❌ The cross product is unable to be calculated  

**Question #7**  
Which of the following is an identity matrix?

1 1 1 ❌  
1 1 1  
1 1 1  

0 0 0 ❌  
0 1 0  
0 0 0  
 
1 0 0 ✔️  
0 1 0  
0 0 1  

**Question #8**  
Which of the following is a zero matrix?

0 1 1 ❌  
1 0 1  
1 1 0  

0 0 0 ✔️  
0 0 0  
0 0 0  

0 0 ✔️  
0 0  

**Question #9**  
To transpose a matrix means to:

❌ Round the values in a matrix to whole numbers  
❌ Calculate the sum of the diagonal of the matrix  
✔️ Switch the rows and columns of the matrix  

**Question #10**  
A determinant is:

✔️ A number calculated from the elements of a square matrix  
❌ A value determining whether a matrix is square or not  
❌ The number of elements in a matrix  

## Tasks

### **0. Pythagoras**  
Given the triangle ABC where **AB = 64** and **BC = 121**, what is the length of **AC**?

<img src="https://github.com/AlisonQuinter17/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/images/pythagoras.png" class="responsive" width="400px"/>

**Solution**  
x² = a² + b²  
x² = 64² + 121²  
x² = 4,096 + 14,641  
x² = 18,737  
x = √18,737  
**x = 136.88** ✔️  

### **1. Magnitude #0 - 2D**  
What is the length of vector v, assuming its origin is 0, 0?

**v** = (3, 9)  
<img src="https://github.com/AlisonQuinter17/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/images/magnitude_2D.png" class="responsive" width="400px"/>

**Solution**  
v = a² + b²  
v = 3² + 9²  
v = 9 + 81  
v = 90  
v = √90  
**v = 9.49** ✔️  

### **2. Magnitude #1 - 3D**  
What is the length of v, assuming its origin is 0, 0, 0?

**v** = (7, -3, -9)  

**Solution**  
v = a² + b² + c²  
v = 7² + (-3)² + (-9)²   
v = 49 + 9 + 81  
v = 139  
v = √139  
**v = 11.79** ✔️  

### **3. Magnitude #2**  
Method that calculates and returns the length of a given vector.
 
- The vector can be 2D or 3D  
- If the vector is not a 2D or 3D vector, return -1  
- The return value should be rounded to the nearest hundredth  

**Solution**  
File: **3-magnitude** ✔️  

### **4. Vector addition #0 - 2D**  
What is the sum of the 2D vectors v and u?

**v** = (8, -11)  
**u** = (-4, 9)  

<img src="https://github.com/AlisonQuinter17/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/images/4-vector_addition_2D.png" class="responsive" width="400px"/>

**Solution**  
v + u = ((8 + (-4)), ((-11) + 9))  
**v + u = (4, -2)** ✔️  

### **5. Vector addition #1 - 3D**  
What is the sum of the 3D vectors v and u?

**v** = (14, -2, 0)  
**u** = (-3, 23, 50)  

**Solution**  
v + u = ((14 + (-2) + 0), ((-3) + 23 + 50))  
**v + u = (11, 21, 50)** ✔️  

### **6. Vector addition #2**  
Method that adds two vectors and returns the resulting vector.

- The vectors can be 2D or 3D  
- If any vector is not a 2D or 3D vector, or if the vectors are not of the same size, return a vector containing -1  

File: **6-vector_addition** ✔️  

### **7. Vector-scalar multiplication #0 - 2D**  
What is the result of multiplying the 2D vector v and scalar x?

**v** = (98, 972)  
**x** = 0.5  

**Solution**  
v × x = ((98 × 0.5), (972 × 0.5))  
**v × x = (49, 486)** ✔️  

### **8. Vector-scalar multiplication #1 - 3D**  
What is the result of multiplying the 3D vector v and scalar x?

**v** = (0, -16, 31)  
**x** = 4  

**Solution**  
v × x = ((0 × 4), (-16 × 4), (31 × 4))  
**v × x = (0, -64, 124)** ✔️  

### **9. Vector-scalar multiplication #2**  
Method that multiplies a vector and a scalar and returns the resulting vector.

- The vectors can be 2D or 3D  
- If any vector is not a 2D or 3D vector, return a vector containing -1

File: **9-vector_scalar_mul** ✔️  

### **10. Dot product #0 - 2D**  
What is the dot product of v and u?

**v** = (1, 3)  
**u** = (-2, 5)    

<img src="https://github.com/AlisonQuinter17/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/images/10-dot_product_2D.png" class="responsive" width="400px"/>

**Solution**  
v . u = (1 × (-2)) + (3 × 5)  
v . u = (-2) + (15)  
**v . u = 13** ✔️  

### **11. Dot product #1 - 3D**  
What is the dot product of v and u?

**v** = (-4, 0, 10)  
**u** = (3, 7, -9)  

**Solution**  
v . u = ((-4) × 3) + (0 × 7) + (10 × (-9))  
v . u = (-12) + (0) + (-90)   
**v . u = -102** ✔️  

### **12. Dot product #2**  
Method that calculates dot product of either two 2D or two 3D vectors.

- The vectors can be either both 2D or both 3D  
- If any vector is not a 2D or 3D vector, or both vectors are not the same size, return -1

File: **12-dot_product** ✔️  

### **13. Matrix addition #0**  
What is the result of adding the two matrices M and N?

**M** =  
(14, -3, 0)  
(-11, -5, 3)  
(2, -9, 13)  

**N** =  
(6, 16, 21)  
(5, 2, 0)  
(1, 3, 7)  

**Solution**  
M + N =  
(14, -3, 0)   +  (6, 16, 21)  
(-11, -5, 3)  +  (5, 2, 0)  
(2, -9, 13)   +  (1, 3, 7)  

M + N =  
((14 + 6), ((-3) + 16), (0 + 21))  
(((-11) + 5), ((-5) + 2), (3 + 0))  
((2 + 1), ((-9) + 3), (13 + 7))  

**M + N =  
(20, 13, 21)  
(-6, -3, 3)  
(3, -6, 20)** ✔️  

### 14. Matrix addition #1  
Method that adds two matrices and returns the resulting matrix.

- The matrices can be either both 2D or both 3D  
- 2D ex.: double[,] matrix = { { 1, 2 }, { 3, 4 } };  
- 3D ex.: double[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };  
- If any matrix is not a 2D or 3D matrix, or both matrices are not the same size, return a matrix containing -1

File: **14-matrix_addition** ✔️  

### **15. Matrix-scalar multiplication #0**  
What is the result of multiplying the matrix M and scalar x?

**M** =  
(-13, 10, 8)  
(2, 0, 14)  
(-4, -5, 2)  

***x*** = 4  

**Solution**  
M × *x* =  
(((-13) ×  4), (10 ×  4), (8 ×  4))  
((2 ×  4), (0 ×  4), (14 ×  4))  
(((-4) ×  4), ((-5) ×  4), (2 ×  4))  

**M + *x* =  
(-52, 40, 32)  
(8, 0, 56)  
(-16, -20, 8)** ✔️  

### **16. Matrix-scalar multiplication #1**  
Method that multiplies a matrix and a scalar and returns the resulting matrix.

- The matrix can be either 2D or 3D  
- If the matrix is not a 2D or 3D matrix, return a matrix containing -1  

File: **16-matrix_scalar_mul** ✔️  
   
### **17. Matrix-matrix multiplication #0**  
What is the result of multiplying the two matrices M and N?  

**M** =  
(2, 3)  
(-1, 0)  

**N** =  
(1, 7)  
(-8, -2)  

**Solution**  
M × N=  

| M | M | Mul | N | N | Result |   Answer  |   Answer  |
|:-:|:-:|:---------:|:-:|:-:|:------:|:---------:|:---------:|
| a | b |     ×     | e | f |    =   | (a×e) + (b×g) | (a×f) + (b×h) |
| c | d |     ×     | g | h |    =   | (c×e) + (d×g) |  (c×f) + (d×h) |

M × N=  

| M | M | Mul | N | N | Result |   Answer  |   Answer  |
|:-:|:-:|:---------:|:-:|:-:|:------:|:---------:|:---------:|
| 2 | 3 |     ×     | 1 | 7 |    =   | (2×1) + (3×(-8)) | (2×7) + (3×(-2)) |
| -1 | 0 |     ×     | -8 | -2 |    =   | ((-1)×1) + (0×(-8)) |  ((-1)×7) + (0×(-2)) |

M × N=  

| M | M | Mul | N | N | Result |   Answer  |   Answer  |
|:-:|:-:|:---------:|:-:|:-:|:------:|:---------:|:---------:|
| 2 | 3 |     ×     | 1 | 7 |    =   | (2) + (-24) | (14) + (-6) |
| -1 | 0 |     ×     | -8 | -2 |    =   | (-1) + (0) |  (-7) + (0) |

M × N=  

| M | M | Mul | N | N | Result |   Answer  |   Answer  |
|:-:|:-:|:---------:|:-:|:-:|:------:|:---------:|:---------:|
| 2 | 3 |     ×     | 1 | 7 |    =   | -22 | 8 |
| -1 | 0 |     ×     | -8 | -2 |    =   | -1 |  -7 |

**M × N =  
(-22, 8)  
(-1, -7)** ✔️   
   
### **18. Matrix-matrix multiplication #1**  
Method that multiplies two matrices and returns the resulting matrix.  

- The matrices will not necessarily be square or the same dimensions  
- If the matrices cannot be multiplied, return a matrix containing -1  

File: **18-matrix_matrix_mul** ✔️  
   
### **19. Matrix rotation #0**  
Rotate the matrix M by angle θ (in radians). What is the resulting matrix?  

**M** =  
(1, 2)  
(3, 4)  

**θ** = -1.57  

**Solution**  

| Radians (rad) | Degrees (°) |
|:-------------:|:-----------:|
|     -1.57     |     -90°    |

R(-θ) =  

[ Cos(θ) - Sin(θ) ] [ x ] = [ x Cos(θ) - y Sin(θ) ]  
[ Sin(θ)  Cos(θ) ] [ y ] = [ x Sin(θ) + y Cos(θ) ]  

R(-θ) =  

[ Cos(θ) - Sin(θ) ]  
[ Sin(θ)  Cos(θ) ]  

R(-θ) =  

[ x¹ ] [ Cos(θ) - Sin(θ) ] [ x ]  
[ y¹ ] [ Sin(θ)  Cos(θ) ] [ y ]  

R(-θ) =  

x¹  =  Cos(θ) - Sin(θ)  
y¹  = Sin(θ) + Cos(θ)  

**R=  
(2, -1)  
(4, -3)** ✔️  
   
### **20. Matrix rotation #1**  
Method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix.  

**NOTE:** “Rotation” in this context means to apply rotation to the value of each element in the matrix, not changing the positions of the values in the matrix.  

- If the matrix is of an invalid size, return a matrix containing -1  

File: **20-matrix_rotate_2D** ✔️  
   
### **21. Matrix shear #0**  
Shear the matrix M by the shear factor s in the **X direction**. What is the resulting matrix?

**M** =  
(1, 2)  
(3, 4)  

**s** = 2  
  
Directions:  

| X |  X |
|:-:|:-:|
| 1 | s |
| 0 | 1 |

| Y |  Y |
|:-:|:-:|
| 1 | 0 |
| s | 1 |

**Solution**

**R=**  
| **x** | = | **1 s** | | **x** |  
| **y** | = | **0 1** | | **y** |  

R= (1, 2)  
| x | = | 1 2 | | 1 |  
| y | = | 0 1 | | 2 |  

R= (1, 2)  
| x | = | (1×1) + (2×2) | | 1 |  
| y | = | (0×1) + (1×2) | | 2 |  

R= (1, 2)  
| x | = | (1) + (4) |  
| y | = | (0) + (2) |  

R= (1, 2)  
| x | = | 5 |  **For (1, 2) the**  
| y | = | 2 |  **answer is (5, 2)**  
<hr>
R= (3, 4)  
| x | = | 1 2 | | 3 |  
| y | = | 0 1 | | 4 |  

R= (3, 4)  
| x | = | (1×3) + (2×4) | | 3 |  
| y | = | (0×3) + (1×4) | | 4 |  

R= (3, 4)  
| x | = | (3) + (8) |  
| y | = | (0) + (4) |  

R= (3, 4)  
| x | = | 11 |  **For (3, 4) the**  
| y | = | 4 |  **answer is (11, 4)**  

**R=  
(5, 2)  
(11, 4)** ✔️  
   
### **22. Matrix shear #1**  
Method that shears a square 2D matrix by a given shear factor and returns the resulting matrix.  

- The shear factor can be in either the X or Y direction but not both  
- If the matrix is of an invalid size, return a matrix containing -1  
- If given an axis that is not x or y, return a matrix containing -1  

File: **24-matrix_shear_2D** ✔️  
   
### **23. Transpose matrix**  
Method to transpose a matrix and return the resulting matrix.  

- The matrix can be of any dimension or size  
- If the matrix is empty, return an empty matrix  

File: **25-matrix_transpose** ✔️  
   
### **24. Determinant #0**  
What is the determinant of matrix M?  

**M** =  
(2, 2)  
(-9, 4)  
   
### **25. Determinant #1**  
What is the determinant of matrix M?  

**M** =  
(-4, 9, 0)  
(1, -2, 1)  
(3, -4, 2)  
   
### **26. Determinant #3**  
Method that calculates the determinant of a matrix.  

- If the matrix is not 2D or 3D, return -1  

File: **28-determinant** ✔️  
   
### **27. Cross product #0**  
What is the cross product of v and u?  

**v** = (2, -2, 1)  
**u** = (-8, 8, -4)  
   
### **28. Cross product #1**  
Method that calculates the cross product of two 3D vectors and returns the resulting vector.  

- If either vector is not a 3D vector, return a vector containing -1  

File: **30-cross_product** ✔️  
   
### **29. Inverse #0**  
What is the inverse of M?  

**M** =  
(1, 2)  
(3, 4)  
   
### **30. Inverse #1**  
What is the inverse of M? Round to the nearest hundredth.

**M** =  
(11, 8, 7)  
(2, 13, 1)  
(4, 0, 17)  
   
### **31. Inverse #2**  
Method that calculates the inverse of a 2D matrix and returns the resulting matrix.

- If the matrix is not a 2D matrix, return [-1]  
- If the matrix is non-invertible, return [-1]  

File: **33-inverse_2D** ✔️  
