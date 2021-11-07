// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IAutoUpdateSettingsOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [Guid(1732844935, 13793, 20778, 137, 104, 26, 232, 141, 27, 230, 211)]
  [ExclusiveTo(typeof (AutoUpdateSettingsOptions))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IAutoUpdateSettingsOptions
  {
    PackageVersion Version { get; set; }

    Uri AppInstallerUri { get; set; }

    bool OnLaunch { get; set; }

    uint HoursBetweenUpdateChecks { get; set; }

    bool ShowPrompt { get; set; }

    bool UpdateBlocksActivation { get; set; }

    bool AutomaticBackgroundTask { get; set; }

    bool ForceUpdateFromAnyVersion { get; set; }

    bool IsAutoRepairEnabled { get; set; }

    IVector<Uri> UpdateUris { get; }

    IVector<Uri> RepairUris { get; }

    IVector<Uri> DependencyPackageUris { get; }

    IVector<Uri> OptionalPackageUris { get; }
  }
}
