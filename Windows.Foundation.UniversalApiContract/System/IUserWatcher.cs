// Decompiled with JetBrains decompiler
// Type: Windows.System.IUserWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(358527547, 9258, 17888, 162, 233, 49, 113, 252, 106, 127, 187)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UserWatcher))]
  internal interface IUserWatcher
  {
    UserWatcherStatus Status { get; }

    void Start();

    void Stop();

    event TypedEventHandler<UserWatcher, UserChangedEventArgs> Added;

    event TypedEventHandler<UserWatcher, UserChangedEventArgs> Removed;

    event TypedEventHandler<UserWatcher, UserChangedEventArgs> Updated;

    event TypedEventHandler<UserWatcher, UserChangedEventArgs> AuthenticationStatusChanged;

    event TypedEventHandler<UserWatcher, UserAuthenticationStatusChangingEventArgs> AuthenticationStatusChanging;

    event TypedEventHandler<UserWatcher, object> EnumerationCompleted;

    event TypedEventHandler<UserWatcher, object> Stopped;
  }
}
