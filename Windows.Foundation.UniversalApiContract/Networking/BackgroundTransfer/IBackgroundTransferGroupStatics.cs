// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundTransferGroupStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundTransferGroup))]
  [Guid(49041586, 32024, 18779, 170, 34, 50, 169, 125, 69, 211, 226)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackgroundTransferGroupStatics
  {
    BackgroundTransferGroup CreateGroup(string name);
  }
}
