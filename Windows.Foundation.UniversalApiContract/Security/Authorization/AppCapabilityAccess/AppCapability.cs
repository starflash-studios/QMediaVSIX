// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authorization.AppCapabilityAccess.AppCapability
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Security.Authorization.AppCapabilityAccess
{
  /// <summary>Creates an AppCapability object for the app's user and the current process.</summary>
  [Static(typeof (IAppCapabilityStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Threading(ThreadingModel.Both)]
  public sealed class AppCapability : IAppCapability
  {
    /// <summary>Accesses the stored capability.</summary>
    /// <returns>The stored capability as a string property.</returns>
    public extern string CapabilityName { [MethodImpl] get; }

    /// <summary>The user under which the AppCapability is created.</summary>
    /// <returns>The user property.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Requests access for the object’s stored capability and user.</summary>
    /// <returns>Returns an AppCapabilityAccessStatus enum.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppCapabilityAccessStatus> RequestAccessAsync();

    /// <summary>Checks access for the object’s stored capability and user.</summary>
    /// <returns>Returns an AppCapabilityAccessStatus (can be UserPromptRequired).</returns>
    [MethodImpl]
    public extern AppCapabilityAccessStatus CheckAccess();

    /// <summary>Raised when there is a change to access status.</summary>
    public extern event TypedEventHandler<AppCapability, AppCapabilityAccessChangedEventArgs> AccessChanged;

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IMapView<string, AppCapabilityAccessStatus>> RequestAccessForCapabilitiesAsync(
      IIterable<string> capabilityNames);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IMapView<string, AppCapabilityAccessStatus>> RequestAccessForCapabilitiesForUserAsync(
      User user,
      IIterable<string> capabilityNames);

    /// <summary>Creates an AppCapability object.</summary>
    /// <param name="capabilityName">The string property of CapabilityName.</param>
    /// <returns>Returns the created instance.</returns>
    [MethodImpl]
    public static extern AppCapability Create(string capabilityName);

    /// <summary>Creates an AppCapability object for the specified process and user.</summary>
    /// <param name="user">The user property for which the object was created.</param>
    /// <param name="capabilityName">The string property of CapabilityName.</param>
    /// <param name="pid">The Process ID.</param>
    /// <returns>Returns the created instance.</returns>
    [MethodImpl]
    public static extern AppCapability CreateWithProcessIdForUser(
      User user,
      string capabilityName,
      uint pid);
  }
}
