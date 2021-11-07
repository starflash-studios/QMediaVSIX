// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.AppListEntry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Core
{
  /// <summary>Provides an app's display info such as its display name and description, and a method to launch the app.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppListEntry : IAppListEntry, IAppListEntry2, IAppListEntry3, IAppListEntry4
  {
    /// <summary>Provides an app's display name, description, and logo.</summary>
    /// <returns>An object representing the app's display name, description, and logo.</returns>
    public extern AppDisplayInfo DisplayInfo { [MethodImpl] get; }

    /// <summary>Launch the app associated with this AppListEntry</summary>
    /// <returns>Returns **true** if the launch succeeds; otherwise, **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> LaunchAsync();

    /// <summary>Gets the Application User Model ID (AUMID) for this **AppListEntry**.</summary>
    /// <returns>A string representing the app's identity.</returns>
    public extern string AppUserModelId { [MethodImpl] get; }

    /// <summary>Launch the app associated with this AppListEntry within the context of a specified user.</summary>
    /// <param name="user">The user context that the app should be launched under.</param>
    /// <returns>Returns **true** if the launch succeeds; otherwise, **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> LaunchForUserAsync(User user);

    public extern AppInfo AppInfo { [MethodImpl] get; }
  }
}
