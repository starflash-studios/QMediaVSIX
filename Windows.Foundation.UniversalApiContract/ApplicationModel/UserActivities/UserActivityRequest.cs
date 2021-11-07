﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.UserActivityRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  /// <summary>Passed as an argument to the UserActivityRequestManager.UserActivityRequested event. Used to return a UserActivity to the caller.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UserActivityRequest : IUserActivityRequest
  {
    /// <summary>Sets the UserActivity to return when the UserActivityRequested event is raised.</summary>
    /// <param name="activity">The user activity to store.</param>
    [MethodImpl]
    public extern void SetUserActivity(UserActivity activity);
  }
}