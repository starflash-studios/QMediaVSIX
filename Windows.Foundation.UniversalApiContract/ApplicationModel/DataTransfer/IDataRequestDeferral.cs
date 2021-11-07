// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataRequestDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (DataRequestDeferral))]
  [Guid(1841608863, 902, 16995, 135, 193, 237, 125, 206, 48, 137, 14)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataRequestDeferral
  {
    void Complete();
  }
}
