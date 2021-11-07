// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageCatalogRemoveResourcePackagesResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Provides information on the status of removing resource packages from an app package.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [DualApiPartition(version = 100794368)]
  public sealed class PackageCatalogRemoveResourcePackagesResult : 
    IPackageCatalogRemoveResourcePackagesResult
  {
    /// <summary>Gets the resource packages that were removed from the app package.</summary>
    /// <returns>The resource packages that were removed.</returns>
    public extern IVectorView<Package> PackagesRemoved { [MethodImpl] get; }

    /// <summary>An extended error code generated when removing a resource package from an app package.</summary>
    /// <returns>The extended error code from removing a resource package.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
