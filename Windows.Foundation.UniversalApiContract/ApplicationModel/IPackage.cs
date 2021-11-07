// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(373061935, 48501, 16700, 191, 35, 177, 254, 123, 149, 216, 37)]
  [ExclusiveTo(typeof (Package))]
  internal interface IPackage
  {
    PackageId Id { get; }

    StorageFolder InstalledLocation { get; }

    bool IsFramework { get; }

    IVectorView<Package> Dependencies { get; }
  }
}
