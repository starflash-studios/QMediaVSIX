// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackage3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (Package))]
  [Guid(1601407841, 63594, 18711, 147, 209, 241, 238, 157, 59, 53, 217)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPackage3
  {
    PackageStatus Status { get; }

    DateTime InstalledDate { get; }

    [RemoteAsync]
    IAsyncOperation<IVectorView<AppListEntry>> GetAppListEntriesAsync();
  }
}
