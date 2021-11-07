// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.AutoUpdateSettingsOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(851968, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutoUpdateSettingsOptionsStatics), 851968, "Windows.Foundation.UniversalApiContract")]
  public sealed class AutoUpdateSettingsOptions : IAutoUpdateSettingsOptions
  {
    [MethodImpl]
    public extern AutoUpdateSettingsOptions();

    public extern PackageVersion Version { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri AppInstallerUri { [MethodImpl] get; [MethodImpl] set; }

    public extern bool OnLaunch { [MethodImpl] get; [MethodImpl] set; }

    public extern uint HoursBetweenUpdateChecks { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ShowPrompt { [MethodImpl] get; [MethodImpl] set; }

    public extern bool UpdateBlocksActivation { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AutomaticBackgroundTask { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ForceUpdateFromAnyVersion { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsAutoRepairEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<Uri> UpdateUris { [MethodImpl] get; }

    public extern IVector<Uri> RepairUris { [MethodImpl] get; }

    public extern IVector<Uri> DependencyPackageUris { [MethodImpl] get; }

    public extern IVector<Uri> OptionalPackageUris { [MethodImpl] get; }

    [MethodImpl]
    public static extern AutoUpdateSettingsOptions CreateFromAppInstallerInfo(
      AppInstallerInfo appInstallerInfo);
  }
}
