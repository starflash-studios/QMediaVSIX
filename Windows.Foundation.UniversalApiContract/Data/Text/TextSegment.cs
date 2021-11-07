// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.TextSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  /// <summary>Identifies a sub-string of a source text string. Your app can use this structure to obtain the segment of your provided text that is identified by AlternateWordForm, SelectableWordSegment, WordSegment, or SemanticTextQuery.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct TextSegment
  {
    /// <summary>The zero-based index of the start of the associated text segment.</summary>
    public uint StartPosition;
    /// <summary>The number of characters in the associated text segment.</summary>
    public uint Length;
  }
}
