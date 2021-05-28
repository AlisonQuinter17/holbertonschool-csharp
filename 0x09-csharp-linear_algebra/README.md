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

v = (0, -16, 31)  
x = 4  

**Solution**  
v × x = ((0 × 4), (-16 × 4), (31 × 4))  
**v × x = (0, -64, 124)** ✔️  

### **9. Vector-scalar multiplication #2**  
Create a method that multiplies a vector and a scalar and returns the resulting vector.

- The vectors can be 2D or 3D  
- If any vector is not a 2D or 3D vector, return a vector containing -1

File: **9-vector_scalar_mul** ✔️  

### **10. Dot product #0 - 2D**  
What is the dot product of v and u?

v = (1, 3)  
u = (-2, 5)  

<img src="https://github.com/AlisonQuinter17/holbertonschool-csharp/blob/main/0x09-csharp-linear_algebra/images/10-dot_product_2D.png" class="responsive" width="400px"/>

**Solution**  
v . u = (1 × (-2)) + (3 × 5)  
v . u = (-2) + (15)  
**v . u = 13** ✔️  
