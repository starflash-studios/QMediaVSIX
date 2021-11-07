// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataProviderDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (DataProviderDeferral))]
  [Guid(3268354931, 11558, 17369, 182, 157, 220, 184, 109, 3, 246, 218)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataProviderDeferral
  {
    void Complete();
  }
}
