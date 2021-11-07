// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.TextDecorations
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Defines constants that specify the decorations applied to text.</summary>
  [WebHostHidden]
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum TextDecorations : uint
  {
    /// <summary>No text decorations are applied.</summary>
    None = 0,
    /// <summary>Underline is applied to the text.</summary>
    Underline = 1,
    /// <summary>Strikethrough is applied to the text.</summary>
    Strikethrough = 2,
  }
}
