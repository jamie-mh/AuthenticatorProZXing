// Copyright (C) 2024 jmh
// SPDX-License-Identifier: GPL-3.0-only

using System;

namespace AuthenticatorPro.ZXing
{
    [Flags]
    internal enum BarcodeFormats
    {
        QrCode = 1 << 13,
    }
}