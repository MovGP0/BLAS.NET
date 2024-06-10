namespace OpenBLAS.PInvoke;

internal static unsafe partial class OpenBlas
{
    /// <summary>
    /// Applies a plane rotation to a single-precision floating-point vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the single-precision floating-point vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the single-precision floating-point vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="c">Pointer to the cosine of the angle of rotation.</param>
    /// <param name="s">Pointer to the sine of the angle of rotation.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "srot_")]
    internal static extern void Srot(int* n, float* x, int* incX, float* y, int* incY, float* c, float* s);

    /// <summary>
    /// Applies a plane rotation to a double-precision floating-point vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the double-precision floating-point vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the double-precision floating-point vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="c">Pointer to the cosine of the angle of rotation.</param>
    /// <param name="s">Pointer to the sine of the angle of rotation.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "drot_")]
    internal static extern void Drot(int* n, double* x, int* incX, double* y, int* incY, double* c, double* s);

    /// <summary>
    /// Applies a plane rotation to a single-precision complex floating-point vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the single-precision complex floating-point vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the single-precision complex floating-point vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="c">Pointer to the cosine of the angle of rotation.</param>
    /// <param name="s">Pointer to the sine of the angle of rotation.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "csrot_")]
    internal static extern void Csrot(int* n, float* x, int* incX, float* y, int* incY, float* c, float* s);

    /// <summary>
    /// Applies a plane rotation to a double-precision complex floating-point vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the double-precision complex floating-point vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the double-precision complex floating-point vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="c">Pointer to the cosine of the angle of rotation.</param>
    /// <param name="s">Pointer to the sine of the angle of rotation.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zdrot_")]
    internal static extern void Zdrot(int* n, double* x, int* incX, double* y, int* incY, double* c, double* s);

    /// <summary>
    /// Constructs a Givens plane rotation for single-precision floating-point numbers.
    /// </summary>
    /// <param name="a">Pointer to the single-precision floating-point value a.</param>
    /// <param name="b">Pointer to the single-precision floating-point value b.</param>
    /// <param name="c">Pointer to the cosine of the rotation.</param>
    /// <param name="s">Pointer to the sine of the rotation.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "srotg_")]
    internal static extern void Srotg(float* a, float* b, float* c, float* s);

    /// <summary>
    /// Constructs a Givens plane rotation for double-precision floating-point numbers.
    /// </summary>
    /// <param name="a">Pointer to the double-precision floating-point value a.</param>
    /// <param name="b">Pointer to the double-precision floating-point value b.</param>
    /// <param name="c">Pointer to the cosine of the rotation.</param>
    /// <param name="s">Pointer to the sine of the rotation.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "drotg_")]
    internal static extern void Drotg(double* a, double* b, double* c, double* s);

    /// <summary>
    /// Constructs a Givens plane rotation for single-precision complex floating-point numbers.
    /// </summary>
    /// <param name="a">Pointer to the single-precision complex floating-point value a.</param>
    /// <param name="b">Pointer to the single-precision complex floating-point value b.</param>
    /// <param name="c">Pointer to the cosine of the rotation.</param>
    /// <param name="s">Pointer to the sine of the rotation.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "crotg_")]
    internal static extern void Crotg(float* a, float* b, float* c, float* s);

    /// <summary>
    /// Constructs a Givens plane rotation for double-precision complex floating-point numbers.
    /// </summary>
    /// <param name="a">Pointer to the double-precision complex floating-point value a.</param>
    /// <param name="b">Pointer to the double-precision complex floating-point value b.</param>
    /// <param name="c">Pointer to the cosine of the rotation.</param>
    /// <param name="s">Pointer to the sine of the rotation.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "zrotg_")]
    internal static extern void Zrotg(double* a, double* b, double* c, double* s);

    /// <summary>
    /// Constructs the modified Givens plane rotation for single-precision floating-point numbers.
    /// </summary>
    /// <param name="d1">Pointer to the first single-precision floating-point value d1.</param>
    /// <param name="d2">Pointer to the second single-precision floating-point value d2.</param>
    /// <param name="x1">Pointer to the single-precision floating-point value x1.</param>
    /// <param name="y1">Pointer to the single-precision floating-point value y1.</param>
    /// <param name="param">Pointer to the parameter array param.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "srotmg_")]
    internal static extern void Srotmg(float* d1, float* d2, float* x1, float* y1, float* param);

    /// <summary>
    /// Constructs the modified Givens plane rotation for double-precision floating-point numbers.
    /// </summary>
    /// <param name="d1">Pointer to the first double-precision floating-point value d1.</param>
    /// <param name="d2">Pointer to the second double-precision floating-point value d2.</param>
    /// <param name="x1">Pointer to the double-precision floating-point value x1.</param>
    /// <param name="y1">Pointer to the double-precision floating-point value y1.</param>
    /// <param name="param">Pointer to the parameter array param.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "drotmg_")]
    internal static extern void Drotmg(double* d1, double* d2, double* x1, double* y1, double* param);

    /// <summary>
    /// Applies the modified Givens plane rotation to a single-precision floating-point vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the single-precision floating-point vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the single-precision floating-point vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="param">Pointer to the parameter array param.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "srotm_")]
    internal static extern void Srotm(int* n, float* x, int* incX, float* y, int* incY, float* param);

    /// <summary>
    /// Applies the modified Givens plane rotation to a double-precision floating-point vector.
    /// </summary>
    /// <param name="n">Pointer to the number of elements in the vector.</param>
    /// <param name="x">Pointer to the double-precision floating-point vector x.</param>
    /// <param name="incX">Pointer to the increment for the elements of x.</param>
    /// <param name="y">Pointer to the double-precision floating-point vector y.</param>
    /// <param name="incY">Pointer to the increment for the elements of y.</param>
    /// <param name="param">Pointer to the parameter array param.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "drotm_")]
    internal static extern void Drotm(int* n, double* x, int* incX, double* y, int* incY, double* param);
}
