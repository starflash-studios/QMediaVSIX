// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.OptionalUINavigationButtons
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  /// <summary>Specifies additional buttons that may be available on a controller that appears as a navigation controller.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum OptionalUINavigationButtons : uint
  {
    /// <summary>No buttons.</summary>
    None = 0,
    /// <summary>Context1 button.</summary>
    Context1 = 1,
    /// <summary>Context2 button.</summary>
    Context2 = 2,
    /// <summary>Context3 button.</summary>
    Context3 = 4,
    /// <summary>Context4 button.</summary>
    Context4 = 8,
    /// <summary>Page up button.</summary>
    PageUp = 16, // 0x00000010
    /// <summary>Page down button.</summary>
    PageDown = 32, // 0x00000020
    /// <summary>Page left button.</summary>
    PageLeft = 64, // 0x00000040
    /// <summary>Page right button.</summary>
    PageRight = 128, // 0x00000080
    /// <summary>Scroll up button.</summary>
    ScrollUp = 256, // 0x00000100
    /// <summary>Scroll down button.</summary>
    ScrollDown = 512, // 0x00000200
    /// <summary>Scroll left button.</summary>
    ScrollLeft = 1024, // 0x00000400
    /// <summary>Scroll right button.</summary>
    ScrollRight = 2048, // 0x00000800
  }
}
