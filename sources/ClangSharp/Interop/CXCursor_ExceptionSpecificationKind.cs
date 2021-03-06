// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

// Ported from https://github.com/llvm/llvm-project/tree/llvmorg-10.0.0/clang/include/clang-c
// Original source is Copyright (c) the LLVM Project and Contributors. Licensed under the Apache License v2.0 with LLVM Exceptions. See NOTICE.txt in the project root for license information.

namespace ClangSharp.Interop
{
    public enum CXCursor_ExceptionSpecificationKind
    {
        CXCursor_ExceptionSpecificationKind_None,
        CXCursor_ExceptionSpecificationKind_DynamicNone,
        CXCursor_ExceptionSpecificationKind_Dynamic,
        CXCursor_ExceptionSpecificationKind_MSAny,
        CXCursor_ExceptionSpecificationKind_BasicNoexcept,
        CXCursor_ExceptionSpecificationKind_ComputedNoexcept,
        CXCursor_ExceptionSpecificationKind_Unevaluated,
        CXCursor_ExceptionSpecificationKind_Uninstantiated,
        CXCursor_ExceptionSpecificationKind_Unparsed,
        CXCursor_ExceptionSpecificationKind_NoThrow,
    }
}
