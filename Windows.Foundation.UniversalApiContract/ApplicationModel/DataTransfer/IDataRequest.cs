// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(1128377915, 64530, 20051, 140, 2, 172, 113, 76, 65, 90, 39)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DataRequest))]
  internal interface IDataRequest
  {
    DataPackage Data { get; set; }

    DateTime Deadline { get; }

    void FailWithDisplayText(string value);

    DataRequestDeferral GetDeferral();
  }
}
