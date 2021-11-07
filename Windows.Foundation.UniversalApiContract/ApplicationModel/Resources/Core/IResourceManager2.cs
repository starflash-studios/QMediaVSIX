// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceManager2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [Guid(2640772716, 42199, 19491, 158, 133, 103, 95, 48, 76, 37, 45)]
  [ExclusiveTo(typeof (ResourceManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IResourceManager2
  {
    IVectorView<NamedResource> GetAllNamedResourcesForPackage(
      string packageName,
      ResourceLayoutInfo resourceLayoutInfo);

    IVectorView<ResourceMap> GetAllSubtreesForPackage(
      string packageName,
      ResourceLayoutInfo resourceLayoutInfo);
  }
}
