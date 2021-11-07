// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.UserActivityRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  /// <summary>Passed to the UserActivityRequestManager.UserActivityRequested event. Allows the handler of the event to pass back a UserActivity.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class UserActivityRequestedEventArgs : IUserActivityRequestedEventArgs
  {
    /// <summary>Gets the UserActivityRequest associated with a call to the UserActivityRequestManager.UserActivityRequested event handler.</summary>
    /// <returns>The **UserActivityRequest** object.</returns>
    public extern UserActivityRequest Request { [MethodImpl] get; }

    /// <summary>Gets a deferral object so that you can have more time to handle the UserActivityRequestManager.UserActivityRequested event.</summary>
    /// <returns>The deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
