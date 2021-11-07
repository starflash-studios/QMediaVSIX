// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IWwwFormUrlDecoderRuntimeClassFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ExclusiveTo(typeof (WwwFormUrlDecoder))]
  [Guid(1535929149, 9390, 16821, 161, 191, 240, 195, 213, 68, 132, 91)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWwwFormUrlDecoderRuntimeClassFactory
  {
    WwwFormUrlDecoder CreateWwwFormUrlDecoder(string query);
  }
}
