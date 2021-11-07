// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageCatalogAddResourcePackageResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Provides information on the status of adding resource packages to an app package.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PackageCatalogAddResourcePackageResult : 
    IPackageCatalogAddResourcePackageResult
  {
    /// <summary>Gets the app package that the resource package was added to.</summary>
    /// <returns>The app package.</returns>
    public extern Package Package { [MethodImpl] get; }

    /// <summary>A boolean value that specifies if the resource package has been completely addded to an app.</summary>
    /// <returns>True if the resource package is completely added; False otherwise.</returns>
    public extern bool IsComplete { [MethodImpl] get; }

    /// <summary>An extended error code generated when adding a resource package to an app package.</summary>
    /// <returns>The extended error code from installing a resource package.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
