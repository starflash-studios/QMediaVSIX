// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.StagePackageOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  /// <summary>Specifies the deployment options that you can configure when you use the StagePackageByUriAsync method to stage a package.</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(655360, "Windows.Foundation.UniversalApiContract")]
  public sealed class StagePackageOptions : IStagePackageOptions
  {
    /// <summary>Creates a new instance of the StagePackageOptions class.</summary>
    [MethodImpl]
    public extern StagePackageOptions();

    /// <summary>Gets the list of URIs of the dependency packages to stage.</summary>
    /// <returns>The list of URIs of the dependency packages to stage.</returns>
    public extern IVector<Uri> DependencyPackageUris { [MethodImpl] get; }

    /// <summary>Gets or sets the volume to which the package is staged.</summary>
    /// <returns>The volume to which the package is staged.</returns>
    public extern PackageVolume TargetVolume { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the list of package family names from the main bundle to be registered.</summary>
    /// <returns>The list of package family names from the main bundle to be registered.</returns>
    public extern IVector<string> OptionalPackageFamilyNames { [MethodImpl] get; }

    /// <summary>Gets the list of URIs of related optional packages to be updated to the same version as the new optional packages.</summary>
    /// <returns>The list of URIs of related optional packages to be updated to the same version as the new optional packages.</returns>
    public extern IVector<Uri> OptionalPackageUris { [MethodImpl] get; }

    /// <summary>Gets the list of URIs of related optional packages to be updated to the same version as the new optional packages.</summary>
    /// <returns>The list of URIs of related optional packages to be updated to the same version as the new optional packages.</returns>
    public extern IVector<Uri> RelatedPackageUris { [MethodImpl] get; }

    /// <summary>Gets or sets the URI of an external disk location outside of the MSIX package where the package manifest can reference application content.</summary>
    /// <returns>The URI of an external disk location outside of the MSIX package where the package manifest can reference application content.</returns>
    public extern Uri ExternalLocationUri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the stub options for the package.</summary>
    /// <returns>The stub options for the package.</returns>
    public extern StubPackageOption StubPackageOption { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the app is installed in developer mode.</summary>
    /// <returns>**TRUE** to install the app in developer mode; otherwise, **FALSE**.</returns>
    public extern bool DeveloperMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether to force a specific version of a package to be staged/registered, regardless of if a higher version is already staged/registered.</summary>
    /// <returns>**TRUE** forces a specific version of a package to be staged/registered, regardless of if a higher version is already staged/registered; otherwise, **FALSE**.</returns>
    public extern bool ForceUpdateFromAnyVersion { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the app skips resource applicability checks. This effectively stages or registers all resource packages that a user passes in to the command, which forces applicability for all packages contained in a bundle. If a user passes in a bundle, all contained resource packages will be registered.</summary>
    /// <returns>**TRUE** instructs the app to skip all resource applicability checks and stages or registers all resource packages; otherwise, **FALSE**.</returns>
    public extern bool InstallAllResources { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether only the required content group will be staged. An app can be installed as a package with the required content group alone.</summary>
    /// <returns>**TRUE** indicates that only the required content group will be staged; otherwise, **FALSE**.</returns>
    public extern bool RequiredContentGroupOnly { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether to stage the package in place.</summary>
    /// <returns>**TRUE** indicates that the package will be staged in place; otherwise, **FALSE**.</returns>
    public extern bool StageInPlace { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether to allow an unsigned package to be added.</summary>
    /// <returns>**TRUE** indicates that an unsigned package can be added; otherwise, **FALSE**.</returns>
    public extern bool AllowUnsigned { [MethodImpl] get; [MethodImpl] set; }
  }
}
