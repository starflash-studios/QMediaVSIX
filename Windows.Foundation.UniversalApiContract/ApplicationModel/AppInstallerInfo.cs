// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppInstallerInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Provides read-only access to the URI of the .appinstaller XML file location. This allows app developers to retrieve the .appinstaller XML file location when needed by their app.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class AppInstallerInfo : IAppInstallerInfo, IAppInstallerInfo2
  {
    /// <summary>Provides read-only access to the URI of the .appinstaller XML file location. This allows app developers to retrieve the .appinstaller XML file location when needed by their app.</summary>
    /// <returns>The URI for the XML file location.</returns>
    public extern Uri Uri { [MethodImpl] get; }

    public extern bool OnLaunch { [MethodImpl] get; }

    public extern uint HoursBetweenUpdateChecks { [MethodImpl] get; }

    public extern bool ShowPrompt { [MethodImpl] get; }

    public extern bool UpdateBlocksActivation { [MethodImpl] get; }

    public extern bool AutomaticBackgroundTask { [MethodImpl] get; }

    public extern bool ForceUpdateFromAnyVersion { [MethodImpl] get; }

    public extern bool IsAutoRepairEnabled { [MethodImpl] get; }

    public extern PackageVersion Version { [MethodImpl] get; }

    public extern DateTime LastChecked { [MethodImpl] get; }

    public extern IReference<DateTime> PausedUntil { [MethodImpl] get; }

    public extern IVectorView<Uri> UpdateUris { [MethodImpl] get; }

    public extern IVectorView<Uri> RepairUris { [MethodImpl] get; }

    public extern IVectorView<Uri> DependencyPackageUris { [MethodImpl] get; }

    public extern IVectorView<Uri> OptionalPackageUris { [MethodImpl] get; }

    public extern AppInstallerPolicySource PolicySource { [MethodImpl] get; }
  }
}
