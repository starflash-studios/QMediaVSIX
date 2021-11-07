// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.AlternateWordForm
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  /// <summary>Identifies an alternate form of the word represented by a WordSegment object.. For example, this may contain a number in a normalized format.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  public sealed class AlternateWordForm : IAlternateWordForm
  {
    /// <summary>Gets the TextSegment that identifies the source text's sub-string for which this AlternateWordForm object is an alternate.</summary>
    /// <returns>The TextSegment structure that identifies the word in your provided text.</returns>
    public extern TextSegment SourceTextSegment { [MethodImpl] get; }

    /// <summary>Gets the text of the alternate word form identified by this AlternateWordForm object.</summary>
    /// <returns>The alternate word form.</returns>
    public extern string AlternateText { [MethodImpl] get; }

    /// <summary>Gets the normalization format for this current AlternateWordForm object.</summary>
    /// <returns>The normalization format.</returns>
    public extern AlternateNormalizationFormat NormalizationFormat { [MethodImpl] get; }
  }
}
