// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ITextReverseConversionGeneratorFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TextReverseConversionGenerator))]
  [Guid(1673450278, 8154, 16886, 137, 213, 35, 221, 234, 60, 114, 154)]
  internal interface ITextReverseConversionGeneratorFactory
  {
    TextReverseConversionGenerator Create(string languageTag);
  }
}
