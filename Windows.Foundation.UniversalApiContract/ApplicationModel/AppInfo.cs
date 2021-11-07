// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel
{
  /// <summary>Provides information about an application such as its name, logo, package information, ID.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAppInfoStatics), 655360, "Windows.Foundation.UniversalApiContract")]
  public sealed class AppInfo : IAppInfo, IAppInfo2, IAppInfo3, IAppInfo4
  {
    /// <summary>Gets the app identifier.</summary>
    /// <returns>The id of the app as defined by the package name in the Package.appxmanifest file.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>An identifier that uniquely identifies the app.</summary>
    /// <returns>The application user model ID for the application.</returns>
    public extern string AppUserModelId { [MethodImpl] get; }

    /// <summary>Gets information that describes the application.</summary>
    /// <returns>An object containing information about the app's name, description, and logo.</returns>
    public extern AppDisplayInfo DisplayInfo { [MethodImpl] get; }

    /// <summary>An identifier that uniquely identifies the app's package.</summary>
    /// <returns>The package family name</returns>
    public extern string PackageFamilyName { [MethodImpl] get; }

    /// <summary>Retrieves the full Package object for the calling AppInfo object.</summary>
    /// <returns>The Package associated with the AppInfo.</returns>
    public extern Package Package { [MethodImpl] get; }

    public extern AppExecutionContext ExecutionContext { [MethodImpl] get; }

    public extern string[] SupportedFileExtensions { [MethodImpl] get; }

    /// <summary>Retrieves the AppInfo object corresponding to the currently running process.</summary>
    /// <returns>The AppInfo that corresponds to the process.</returns>
    public static extern AppInfo Current { [MethodImpl] get; }

    /// <summary>Retrieves the AppInfo object associated with an AppUserModelId (AUMID).</summary>
    /// <param name="appUserModelId">The AUMID of the app from which to retrieve the AppInfo.</param>
    /// <returns>The AppInfo corresponding to the given AUMID.</returns>
    [MethodImpl]
    public static extern AppInfo GetFromAppUserModelId(string appUserModelId);

    /// <summary>Retrieves the AppInfo object associated with a specified User and AppUserModelId (AUMID).</summary>
    /// <param name="user">The User whose AppInfos you wish to access.</param>
    /// <param name="appUserModelId">The AUMID of the app from which to retrieve the AppInfo.</param>
    /// <returns>The AppInfo corresponding to the given AUMID and user.</returns>
    [MethodImpl]
    public static extern AppInfo GetFromAppUserModelIdForUser(
      User user,
      string appUserModelId);
  }
}
