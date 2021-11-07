// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IESimWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(3254275307, 41613, 20415, 151, 113, 110, 49, 184, 28, 207, 34)]
  [ExclusiveTo(typeof (ESimWatcher))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IESimWatcher
  {
    ESimWatcherStatus Status { get; }

    void Start();

    void Stop();

    event TypedEventHandler<ESimWatcher, ESimAddedEventArgs> Added;

    event TypedEventHandler<ESimWatcher, object> EnumerationCompleted;

    event TypedEventHandler<ESimWatcher, ESimRemovedEventArgs> Removed;

    event TypedEventHandler<ESimWatcher, object> Stopped;

    event TypedEventHandler<ESimWatcher, ESimUpdatedEventArgs> Updated;
  }
}
