// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayBitsPerChannel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Defines constants that specify a number of bits per channel, as flags.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum DisplayBitsPerChannel : uint
  {
    /// <summary>Indicates no specific number of bits per channel.</summary>
    None = 0,
    /// <summary>Indicates 6 bits per channel.</summary>
    Bpc6 = 1,
    /// <summary>Indicates 8 bits per channel.</summary>
    Bpc8 = 2,
    /// <summary>Indicates 10 bits per channel.</summary>
    Bpc10 = 4,
    /// <summary>Indicates 12 bits per channel.</summary>
    Bpc12 = 8,
    /// <summary>Indicates 14 bits per channel.</summary>
    Bpc14 = 16, // 0x00000010
    /// <summary>Indicates 16 bits per channel.</summary>
    Bpc16 = 32, // 0x00000020
  }
}
