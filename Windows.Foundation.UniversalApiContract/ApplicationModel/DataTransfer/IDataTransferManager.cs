// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataTransferManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (DataTransferManager))]
  [Guid(2781539995, 34568, 18897, 141, 54, 103, 210, 90, 141, 160, 12)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataTransferManager
  {
    event TypedEventHandler<DataTransferManager, DataRequestedEventArgs> DataRequested;

    event TypedEventHandler<DataTransferManager, TargetApplicationChosenEventArgs> TargetApplicationChosen;
  }
}
