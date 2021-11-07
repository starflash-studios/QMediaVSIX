// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageCatalogRemoveOptionalPackagesResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Provides information on the status of removing optional packages.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class PackageCatalogRemoveOptionalPackagesResult : 
    IPackageCatalogRemoveOptionalPackagesResult
  {
    /// <summary>A list of the optional packages that were successfully removed from the user account.</summary>
    /// <returns>A list of optional packages that were removed.</returns>
    public extern IVectorView<Package> PackagesRemoved { [MethodImpl] get; }

    /// <summary>Contains the extended error information for removing optional packages.</summary>
    /// <returns>The extended error information.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
