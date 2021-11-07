// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.INamedResource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [Guid(479773209, 2835, 16960, 137, 165, 212, 149, 220, 24, 154, 0)]
  [ExclusiveTo(typeof (NamedResource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface INamedResource
  {
    Uri Uri { get; }

    IVectorView<ResourceCandidate> Candidates { get; }

    [Overload("Resolve")]
    ResourceCandidate Resolve();

    [Overload("ResolveForContext")]
    ResourceCandidate Resolve(ResourceContext resourceContext);

    [Overload("ResolveAll")]
    IVectorView<ResourceCandidate> ResolveAll();

    [Overload("ResolveAllForContext")]
    IVectorView<ResourceCandidate> ResolveAll(
      ResourceContext resourceContext);
  }
}
