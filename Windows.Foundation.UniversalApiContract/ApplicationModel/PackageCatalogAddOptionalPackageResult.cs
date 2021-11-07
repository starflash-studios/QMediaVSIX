// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageCatalogAddOptionalPackageResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Provides information about the result of adding an optional package to the package catalog.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class PackageCatalogAddOptionalPackageResult : 
    IPackageCatalogAddOptionalPackageResult
  {
    /// <summary>Get the optional package that was added to the package catalog.</summary>
    /// <returns>The optional package or **null** if the package could not be added.</returns>
    public extern Package Package { [MethodImpl] get; }

    /// <summary>Provides error information about the attempt to add an optional package to the catalog.</summary>
    /// <returns>The exception if one occurred while adding the optional package; **null** otherwise.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
