// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceMap
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1915242532, 56204, 17144, 176, 140, 83, 255, 53, 125, 173, 130)]
  [ExclusiveTo(typeof (ResourceMap))]
  internal interface IResourceMap : 
    IMapView<string, NamedResource>,
    IIterable<IKeyValuePair<string, NamedResource>>
  {
    Uri Uri { get; }

    [Overload("GetValue")]
    ResourceCandidate GetValue(string resource);

    [Overload("GetValueForContext")]
    ResourceCandidate GetValue(string resource, ResourceContext context);

    ResourceMap GetSubtree(string reference);
  }
}
