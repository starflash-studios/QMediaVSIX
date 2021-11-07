// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Provides the status of the package.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PackageStatus : IPackageStatus, IPackageStatus2
  {
    /// <summary>Indicates whether the package is in good condition and may be used.</summary>
    /// <returns>**TRUE** indicates that the package is in good condition; otherwise **FALSE**.</returns>
    [MethodImpl]
    public extern bool VerifyIsOK();

    /// <summary>Indicates whether the package is available.</summary>
    /// <returns>**TRUE** indicates that the package is not available; otherwise **FALSE**.</returns>
    public extern bool NotAvailable { [MethodImpl] get; }

    /// <summary>Indicates whether the package is offline and cannot be used.</summary>
    /// <returns>**TRUE** indicates that the package is offline; otherwise **FALSE**.</returns>
    public extern bool PackageOffline { [MethodImpl] get; }

    /// <summary>Indicates whether the data for the package is offline.</summary>
    /// <returns>**TRUE** indicates that the data for the package is installed on a volume which is currently offline or cannot be accessed; otherwise **FALSE**.</returns>
    public extern bool DataOffline { [MethodImpl] get; }

    /// <summary>Indicates whether the package has been disabled.</summary>
    /// <returns>**TRUE** indicates that the package is disabled; otherwise **FALSE**.</returns>
    public extern bool Disabled { [MethodImpl] get; }

    /// <summary>Indicates whether the package is unusable.</summary>
    /// <returns>**FALSE** indicates that the package is in a usable state; otherwise **TRUE**.</returns>
    public extern bool NeedsRemediation { [MethodImpl] get; }

    /// <summary>Indicates whether there is a problem with the license for this package.</summary>
    /// <returns>**TRUE** indicates that there is a problem with the license for this package; otherwise **FALSE**.</returns>
    public extern bool LicenseIssue { [MethodImpl] get; }

    /// <summary>Indicates whether the package is missing files, system information, etc.</summary>
    /// <returns>**TRUE** indicates that there is a problem with the package such as missing files; otherwise **FALSE**.</returns>
    public extern bool Modified { [MethodImpl] get; }

    /// <summary>Indicates whether the package may have been tampered with.</summary>
    /// <returns>**TRUE** indicates that the package has been tampered with; otherwise **FALSE**.</returns>
    public extern bool Tampered { [MethodImpl] get; }

    /// <summary>Indicates whether this package depends on a package that can't be used.</summary>
    /// <returns>**TRUE** indicates that there is a problem with a package that this package depends on; otherwise **FALSE**.</returns>
    public extern bool DependencyIssue { [MethodImpl] get; }

    /// <summary>Indicates whether the package is being serviced.</summary>
    /// <returns>**TRUE** indicates that the package is being serviced; otherwise **FALSE**.</returns>
    public extern bool Servicing { [MethodImpl] get; }

    /// <summary>Indicates whether the package is being serviced.</summary>
    /// <returns>**TRUE** indicates that the package is being serviced and consequently cannot be used; otherwise **FALSE**.</returns>
    public extern bool DeploymentInProgress { [MethodImpl] get; }

    /// <summary>Indicates whether the package is partially staged.</summary>
    /// <returns>**True** means that the package is partially staged; **false**, otherwise.</returns>
    public extern bool IsPartiallyStaged { [MethodImpl] get; }
  }
}
