// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.WindowsIntegrityPolicy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  /// <summary>Provides information about the current Windows 10 secure mode (10 S mode), and an event that is raised when the mode changes.</summary>
  [Static(typeof (IWindowsIntegrityPolicyStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public static class WindowsIntegrityPolicy
  {
    /// <summary>Gets a value that indicates whether or not Windows 10 secure mode (10 S mode) is enabled (Windows Lockdown mode).</summary>
    /// <returns>`true` if Windows 10 secure mode (10 S mode) is enabled (Windows Lockdown mode), otherwise `false`.</returns>
    public static extern bool IsEnabled { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether or not Windows 10 secure mode (10 S mode) is enabled (Windows Lockdown mode) for trial purposes.</summary>
    /// <returns>`true` if Windows 10 secure mode (10 S mode) is enabled (Windows Lockdown mode) for trial purposes, otherwise `false`.</returns>
    public static extern bool IsEnabledForTrial { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether or not Windows 10 secure mode (10 S mode) can be disabled by any means—at run time and/or offline; by the original equipment manufacturere (OEM), or by a third party.</summary>
    /// <returns>`true` if Windows 10 secure mode (10 S mode) can be disabled by any means, otherwise `false`.</returns>
    public static extern bool CanDisable { [MethodImpl] get; }

    /// <summary>Gets a value that indicates (see Remarks for other necessary conditions) whether or not there is any published way, or API, for third-party vendors to disable Windows 10 secure mode (10 S mode) at run time.</summary>
    /// <returns>`true` (but see Remarks for other necessary conditions) if there is any published way, or API, for third-party vendors to disable Windows 10 secure mode (10 S mode) at run time, otherwise `false`.</returns>
    public static extern bool IsDisableSupported { [MethodImpl] get; }

    /// <summary>Raised when the current Windows 10 secure mode (10 S mode) changes.</summary>
    public static extern event EventHandler<object> PolicyChanged;
  }
}
