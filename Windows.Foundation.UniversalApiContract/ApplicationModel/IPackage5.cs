// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackage5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (Package))]
  [Guid(243543508, 55724, 17901, 154, 30, 116, 206, 5, 107, 38, 53)]
  internal interface IPackage5
  {
    [RemoteAsync]
    IAsyncOperation<IVector<PackageContentGroup>> GetContentGroupsAsync();

    [RemoteAsync]
    IAsyncOperation<PackageContentGroup> GetContentGroupAsync(
      string name);

    [Overload("StageContentGroupsAsync")]
    [RemoteAsync]
    IAsyncOperation<IVector<PackageContentGroup>> StageContentGroupsAsync(
      IIterable<string> names);

    [RemoteAsync]
    [Overload("StageContentGroupsWithPriorityAsync")]
    IAsyncOperation<IVector<PackageContentGroup>> StageContentGroupsAsync(
      IIterable<string> names,
      bool moveToHeadOfQueue);

    [RemoteAsync]
    IAsyncOperation<bool> SetInUseAsync(bool inUse);
  }
}
