// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.UserActivitySessionHistoryItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  /// <summary>Provides the start and end time that a user was engaged in a particular activity.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class UserActivitySessionHistoryItem : IUserActivitySessionHistoryItem
  {
    /// <summary>Gets the UserActivity associated with this **UserActivitySessionHistoryItem**.</summary>
    /// <returns>The **UserActivity** instance associated with this **UserActivitySessionHistoryItem**.</returns>
    public extern UserActivity UserActivity { [MethodImpl] get; }

    /// <summary>Get the time when the user started engaging in the UserActivity associated with this **UserActivitySessionHistoryItem**.</summary>
    /// <returns>The start time for the **UserActivity**.</returns>
    public extern DateTime StartTime { [MethodImpl] get; }

    /// <summary>Get the time when the user stopped engaging in the UserActivity associated with this **UserActivitySessionHistoryItem**.</summary>
    /// <returns>The stop time for the **UserActivity**.</returns>
    public extern IReference<DateTime> EndTime { [MethodImpl] get; }
  }
}
