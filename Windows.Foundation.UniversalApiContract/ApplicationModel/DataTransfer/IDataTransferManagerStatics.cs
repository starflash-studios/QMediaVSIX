// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataTransferManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (DataTransferManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2849636778, 57358, 19710, 170, 68, 45, 217, 50, 220, 163, 216)]
  internal interface IDataTransferManagerStatics
  {
    void ShowShareUI();

    DataTransferManager GetForCurrentView();
  }
}
