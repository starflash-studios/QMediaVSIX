// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataProviderRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3954995543, 54216, 18394, 172, 222, 248, 35, 136, 213, 247, 22)]
  [ExclusiveTo(typeof (DataProviderRequest))]
  internal interface IDataProviderRequest
  {
    string FormatId { get; }

    DateTime Deadline { get; }

    DataProviderDeferral GetDeferral();

    void SetData([HasVariant] object value);
  }
}
