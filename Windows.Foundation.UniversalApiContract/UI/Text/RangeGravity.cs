// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.RangeGravity
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Specifies the gravity for a text range.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum RangeGravity
  {
    /// <summary>Use selection user interface rules.</summary>
    UIBehavior,
    /// <summary>Use the formatting of the previous text run when on a boundary between runs.</summary>
    Backward,
    /// <summary>Use the formatting of the following text run when on a boundary between runs.</summary>
    Forward,
    /// <summary>The start of the text range has forward gravity, and the end has backward gravity.</summary>
    Inward,
    /// <summary>The start of the text range has backward gravity, and the end has forward gravity.</summary>
    Outward,
  }
}
