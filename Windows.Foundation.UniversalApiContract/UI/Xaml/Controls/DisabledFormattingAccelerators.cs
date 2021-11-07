// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.DisabledFormattingAccelerators
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify which keyboard shortcuts for formatting are disabled in a RichEditBox.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Flags]
  public enum DisabledFormattingAccelerators : uint
  {
    /// <summary>No keyboard shortcuts are disabled.</summary>
    None = 0,
    /// <summary>The keyboard shortcut for bold (Ctrl+B) is disabled.</summary>
    Bold = 1,
    /// <summary>The keyboard shortcut for italic (Ctrl+I) is disabled.</summary>
    Italic = 2,
    /// <summary>The keyboard shortcut for underline (Ctrl+U) is disabled.</summary>
    Underline = 4,
    /// <summary>All keyboard shortcuts are disabled.</summary>
    All = 4294967295, // 0xFFFFFFFF
  }
}
