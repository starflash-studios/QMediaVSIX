// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Resources.Core
{
  [Guid(4148484475, 39304, 17659, 171, 214, 83, 120, 132, 76, 250, 139)]
  [ExclusiveTo(typeof (ResourceManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IResourceManager
  {
    ResourceMap MainResourceMap { get; }

    IMapView<string, ResourceMap> AllResourceMaps { get; }

    ResourceContext DefaultContext { get; }

    void LoadPriFiles(IIterable<IStorageFile> files);

    void UnloadPriFiles(IIterable<IStorageFile> files);
  }
}
