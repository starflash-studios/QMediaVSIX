// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.Pnp.IPnpObjectWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration.Pnp
{
  [ExclusiveTo(typeof (PnpObjectWatcher))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2211011752, 18290, 19066, 172, 168, 228, 140, 66, 168, 156, 68)]
  internal interface IPnpObjectWatcher
  {
    event TypedEventHandler<PnpObjectWatcher, PnpObject> Added;

    event TypedEventHandler<PnpObjectWatcher, PnpObjectUpdate> Updated;

    event TypedEventHandler<PnpObjectWatcher, PnpObjectUpdate> Removed;

    event TypedEventHandler<PnpObjectWatcher, object> EnumerationCompleted;

    event TypedEventHandler<PnpObjectWatcher, object> Stopped;

    DeviceWatcherStatus Status { get; }

    void Start();

    void Stop();
  }
}
