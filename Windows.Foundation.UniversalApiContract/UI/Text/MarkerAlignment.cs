// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.MarkerAlignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Defines bullet and numbering alignment.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MarkerAlignment
  {
    /// <summary>The value is undefined.</summary>
    Undefined,
    /// <summary>Text is left aligned.</summary>
    Left,
    /// <summary>Text is centered in the line.</summary>
    Center,
    /// <summary>Text is right aligned.</summary>
    Right,
  }
}
