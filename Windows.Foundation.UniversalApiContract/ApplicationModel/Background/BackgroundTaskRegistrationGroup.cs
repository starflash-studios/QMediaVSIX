// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BackgroundTaskRegistrationGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Provides grouping semantics so that background task registration can be maintained separately.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IBackgroundTaskRegistrationGroupFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class BackgroundTaskRegistrationGroup : IBackgroundTaskRegistrationGroup
  {
    /// <summary>Creates a **BackgroundTaskRegistrationGroup** with the specified group ID.</summary>
    /// <param name="id">The group ID.</param>
    [MethodImpl]
    public extern BackgroundTaskRegistrationGroup(string id);

    /// <summary>Creates a **BackgroundTaskRegistrationGroup** with the specified group ID and</summary>
    /// <param name="id">The group ID.</param>
    /// <param name="name">The friendly name for this group.</param>
    [MethodImpl]
    public extern BackgroundTaskRegistrationGroup(string id, string name);

    /// <summary>Gets the group ID.</summary>
    /// <returns>The group ID.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the friendly name of the group.</summary>
    /// <returns>The friendly name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>This event is fired when a background task that belongs to a group starts.</summary>
    public extern event TypedEventHandler<BackgroundTaskRegistrationGroup, BackgroundActivatedEventArgs> BackgroundActivated;

    /// <summary>Gets all of the background tasks that belong to the group.</summary>
    /// <returns>The background tasks that belong to the group.</returns>
    public extern IMapView<Guid, BackgroundTaskRegistration> AllTasks { [MethodImpl] get; }
  }
}
