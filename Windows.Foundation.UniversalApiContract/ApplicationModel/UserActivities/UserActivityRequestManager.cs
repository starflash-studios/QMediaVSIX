// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.UserActivityRequestManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  /// <summary>Handle external requests to create a UserActivity.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Static(typeof (IUserActivityRequestManagerStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  public sealed class UserActivityRequestManager : IUserActivityRequestManager
  {
    /// <summary>Raised when a request is made to the application to create an on-demand UserActivity object.</summary>
    public extern event TypedEventHandler<UserActivityRequestManager, UserActivityRequestedEventArgs> UserActivityRequested;

    /// <summary>Gets the UserActivityRequestManager associated with the current view.</summary>
    /// <returns>The **UserActivityRequestManager** for the current view.</returns>
    [MethodImpl]
    public static extern UserActivityRequestManager GetForCurrentView();
  }
}
