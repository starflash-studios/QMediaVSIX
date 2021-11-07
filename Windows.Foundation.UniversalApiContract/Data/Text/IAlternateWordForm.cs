// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.IAlternateWordForm
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [Guid(1194945566, 20921, 16903, 145, 70, 36, 142, 99, 106, 29, 29)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AlternateWordForm))]
  internal interface IAlternateWordForm
  {
    TextSegment SourceTextSegment { get; }

    string AlternateText { get; }

    AlternateNormalizationFormat NormalizationFormat { get; }
  }
}
