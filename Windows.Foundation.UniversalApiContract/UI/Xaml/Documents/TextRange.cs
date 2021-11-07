// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.TextRange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  /// <summary>Represents a selection of text content.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  public struct TextRange
  {
    /// <summary>The position that marks the beginning of the current selection, measured in Unicode characters from the beginning of the text.</summary>
    public int StartIndex;
    /// <summary>The length of the current selection, in Unicode characters.</summary>
    public int Length;
  }
}
