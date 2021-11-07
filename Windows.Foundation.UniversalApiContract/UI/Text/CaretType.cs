// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.CaretType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Specifies the caret type.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CaretType
  {
    /// <summary>The insertion point for a sequenced language; that is, characters that are typed with one key stroke.</summary>
    Normal,
    /// <summary>The insertion point is null.</summary>
    Null,
  }
}
