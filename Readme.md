# Basic Linear Algebra Subprograms (BLAS)

<img src="logo.webp" width=200 height=200 />

The Basic Linear Algebra Subprograms (BLAS) define a set of fundamental operations on vectors and matrices which can be used to create optimized higher-level linear algebra functionality.

There are three levels of BLAS operations,

| Level  | Description              | Example                    |
|:------:|--------------------------|----------------------------|
|   1    | Vector operations        | $y = \alpha x + y$         |
|   2    | Matrix-vector operations | $y = \alpha A x + \beta y$ |
|   3    | Matrix-matrix operations | $C = \alpha A B + C$       |

Each operation is defined for four precisions,

| Type | Description                          | .NET Type       |
|------|--------------------------------------|-----------------|
| S    | single real                          | `float`         |
| D    | double real                          | `double`        |
| C    | single complex                       | `ComplexFloat`  |
| Z    | double complex                       | `ComplexDouble` |
| X    | quadruple/extended precision real    | *not supported* |
| Q    | quadruple/extended precision complex | *not supported* |

The types of matrices are,

| Type | Description              |
|------|--------------------------|
| A    | scalar                   |
| GE   | general matrix           |
| GB   | general band matrix      |
| SY   | symmetric matrix         |
| SB   | symmetric band matrix    |
| SP   | symmetric packed matrix  |
| HE   | hermitian matrix         |
| HB   | hermitian band matrix    |
| HP   | hermitian packed matrix  |
| TR   | triangular matrix        |
| TB   | triangular band matrix   |
| TP   | triangular packed matrix |
| PO   | positive definite matrix |

Each routine has a name which specifies the operation, the type of matrices involved and their precisions.
Some of the most common operations and their names are given below,

| Name | Description           | Math           |
|:-----|-----------------------|----------------|
| DOT  | scalar product        | $x^T y$        |
| AXPY | vector sum            | $\alpha x + y$ |
| MV   | matrix-vector product | $A x$          |
| SV   | matrix-vector solve   | $inv(A) x$     |
| MM   | matrix-matrix product | $A B$          |
| SM   | matrix-matrix solve   | $inv(A) B$     |

**Example**

- `SGEMM` stands for "single-precision general matrix-matrix multiply"
- `ZGEMM` stands for "double-precision complex matrix-matrix multiply".

## Header Files

- [BLAS++ Header Files](https://github.com/icl-utk-edu/blaspp/tree/master/include/blas)

## Literature

- C. Lawson, R. Hanson, D. Kincaid, F. Krogh, "Basic Linear Algebra Subprograms for Fortran Usage", ACM Transactions on Mathematical Software, Vol.: 5 (1979), Pages 308–325.
- J.J. Dongarra, J. DuCroz, S. Hammarling, R. Hanson, "An Extended Set of Fortran Basic Linear Algebra Subprograms", ACM Transactions on Mathematical Software, Vol.: 14, No.: 1 (1988), Pages 1–32.
- J.J. Dongarra, I. Duff, J. DuCroz, S. Hammarling, "A Set of Level 3 Basic Linear Algebra Subprograms", ACM Transactions on Mathematical Software, Vol.: 16 (1990), Pages 1–28.
