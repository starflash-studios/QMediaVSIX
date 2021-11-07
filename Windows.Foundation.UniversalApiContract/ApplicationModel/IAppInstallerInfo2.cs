// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IAppInstallerInfo2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(3524203400, 33366, 22908, 133, 17, 200, 78, 197, 13, 94, 43)]
  [ExclusiveTo(typeof (AppInstallerInfo))]
  internal interface IAppInstallerInfo2
  {
    bool OnLaunch { get; }

    uint HoursBetweenUpdateChecks { get; }

    bool ShowPrompt { get; }

    bool UpdateBlocksActivation { get; }

    bool AutomaticBackgroundTask { get; }

    bool ForceUpdateFromAnyVersion { get; }

    bool IsAutoRepairEnabled { get; }

    PackageVersion Version { get; }

    DateTime LastChecked { get; }

    IReference<DateTime> PausedUntil { get; }

    IVectorView<Uri> UpdateUris { get; }

    IVectorView<Uri> RepairUris { get; }

    IVectorView<Uri> DependencyPackageUris { get; }

    IVectorView<Uri> OptionalPackageUris { get; }

    AppInstallerPolicySource PolicySource { get; }
  }
}
