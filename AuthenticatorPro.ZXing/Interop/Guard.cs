// Copyright (C) 2024 jmh
// SPDX-License-Identifier: GPL-3.0-only

using System;

namespace AuthenticatorPro.ZXing.Interop
{
    public static class Guard
    {
        public static void ThrowIfNullPointer(IntPtr handle)
        {
            if (handle == IntPtr.Zero)
            {
                throw new ZXingException(NativeMethods.LastErrorMessage());
            }
        }
    }
}