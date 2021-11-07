// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageCatalogAddOptionalPackageResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [Guid(1005653204, 46303, 18355, 169, 99, 226, 250, 131, 47, 125, 211)]
  [ExclusiveTo(typeof (PackageCatalogAddOptionalPackageResult))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPackageCatalogAddOptionalPackageResult
  {
    Package Package { get; }

    HResult ExtendedError { get; }
  }
}
