// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.WordSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  /// <summary>Represents a word from your provided text.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WordSegment : IWordSegment
  {
    /// <summary>Gets the text of the word identified by this WordSegment object.</summary>
    /// <returns>The current word.</returns>
    public extern string Text { [MethodImpl] get; }

    /// <summary>Gets the TextSegment that identifies the source text's sub-string that is a word.</summary>
    /// <returns>The TextSegment structure that identifies the word in your provided text.</returns>
    public extern TextSegment SourceTextSegment { [MethodImpl] get; }

    /// <summary>Gets the alternate forms (if any) associated with the current word.</summary>
    /// <returns>A collection of AlternateWordForm objects that represent alternate forms of the current word.</returns>
    public extern IVectorView<AlternateWordForm> AlternateForms { [MethodImpl] get; }
  }
}
