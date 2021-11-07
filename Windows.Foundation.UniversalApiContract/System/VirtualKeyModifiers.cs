// Decompiled with JetBrains decompiler
// Type: Windows.System.VirtualKeyModifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Specifies the virtual key used to modify another keypress. For example, the Ctrl key when pressed in conjunction with another key, as in Ctrl+C.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VirtualKeyModifiers : uint
  {
    /// <summary>No virtual key modifier.</summary>
    None = 0,
    /// <summary>The Ctrl (control) virtual key.</summary>
    Control = 1,
    /// <summary>The Menu virtual key.</summary>
    Menu = 2,
    /// <summary>The Shift virtual key.</summary>
    Shift = 4,
    /// <summary>The Windows virtual key.</summary>
    Windows = 8,
  }
}
