// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandAccountWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1811100510, 9141, 17567, 146, 141, 94, 13, 62, 4, 71, 29)]
  [ExclusiveTo(typeof (MobileBroadbandAccountWatcher))]
  internal interface IMobileBroadbandAccountWatcher
  {
    event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountEventArgs> AccountAdded;

    event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountUpdatedEventArgs> AccountUpdated;

    event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountEventArgs> AccountRemoved;

    event TypedEventHandler<MobileBroadbandAccountWatcher, object> EnumerationCompleted;

    event TypedEventHandler<MobileBroadbandAccountWatcher, object> Stopped;

    MobileBroadbandAccountWatcherStatus Status { get; }

    void Start();

    void Stop();
  }
}
