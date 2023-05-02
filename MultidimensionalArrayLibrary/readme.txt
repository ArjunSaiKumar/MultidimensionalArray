(n-dimensional array) library for C# targeting .Net 6.0

      Core features:
        - n-dimensional arrays (tensors) in host memory or on CUDA GPUs 
        - element-wise operations (addition, multiplication, absolute value, etc.)
        - basic linear algebra operations (dot product, SVD decomposition, matrix inverse, etc.)
        - reduction operations (sum, product, average, maximum, arg max, etc.)
        - logic operations (comparision, and, or, etc.)
        - views, slicing, reshaping, broadcasting (similar to NumPy) 
        - scatter and gather by indices
        - standard functional operations (map, fold, etc.)

      Data exchange:
        - read/write support for HDF5 (.h5)
        - interop with standard F# types (Seq, List, Array, Array2D, Array3D, etc.)

      Performance:
        - host: SIMD and BLAS accelerated operations 
          - by default Intel MKL is used (shipped with NuGet package)
          - other BLASes (OpenBLAS, vendor-specific) can be selected by configuration option
        - CUDA GPU: all operations performed locally on GPU and cuBLAS used for matrix operations

      Requirements: 
        - Linux, MacOS or Windows on x64
        - Linux requires libgomp.so.1 installed.
