// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.IWordSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ExclusiveTo(typeof (WordSegment))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3537156717, 39036, 19648, 182, 189, 212, 154, 17, 179, 143, 154)]
  internal interface IWordSegment
  {
    string Text { get; }

    TextSegment SourceTextSegment { get; }

    IVectorView<AlternateWordForm> AlternateForms { get; }
  }
}
