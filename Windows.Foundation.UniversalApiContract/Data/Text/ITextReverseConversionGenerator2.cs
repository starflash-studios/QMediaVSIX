// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ITextReverseConversionGenerator2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(447730412, 34262, 18173, 130, 138, 58, 72, 48, 250, 110, 24)]
  [ExclusiveTo(typeof (TextReverseConversionGenerator))]
  internal interface ITextReverseConversionGenerator2
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<TextPhoneme>> GetPhonemesAsync(
      string input);
  }
}
