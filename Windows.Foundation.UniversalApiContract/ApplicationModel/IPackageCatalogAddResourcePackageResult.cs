// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageCatalogAddResourcePackageResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [Guid(2520174093, 15895, 18751, 170, 8, 204, 236, 111, 222, 246, 153)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (PackageCatalogAddResourcePackageResult))]
  internal interface IPackageCatalogAddResourcePackageResult
  {
    Package Package { get; }

    bool IsComplete { get; }

    HResult ExtendedError { get; }
  }
}
