// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.ResourceMap
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  /// <summary>A collection of related resources, typically either for a particular app package, or a resource file for a particular package.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ResourceMap : 
    IResourceMap,
    IMapView<string, NamedResource>,
    IIterable<IKeyValuePair<string, NamedResource>>
  {
    /// <summary>Gets a URI that can be used to refer to this ResourceMap.</summary>
    /// <returns>The URI that refers to this ResourceMap.</returns>
    public extern Uri Uri { [MethodImpl] get; }

    /// <summary>Returns the most appropriate candidate for a resource that is specified by a resource identifier within the default context.</summary>
    /// <param name="resource">A resource identifier specified as a name or reference. For details, see the remarks for ResourceMap class.</param>
    /// <returns>A ResourceCandidate that describes the most appropriate candidate.</returns>
    [Overload("GetValue")]
    [MethodImpl]
    public extern ResourceCandidate GetValue(string resource);

    /// <summary>Returns the most appropriate candidate for a resource that is specified by a resource identifier for the supplied context.</summary>
    /// <param name="resource">A resource specified as a name or reference. For details, see the remarks for ResourceMap class.</param>
    /// <param name="context">The context for which to select the most appropriate candidate.</param>
    /// <returns>A ResourceCandidate that describes the most appropriate candidate.</returns>
    [Overload("GetValueForContext")]
    [MethodImpl]
    public extern ResourceCandidate GetValue(
      string resource,
      ResourceContext context);

    /// <summary>Returns a ResourceMap that represents a part of another ResourceMap, typically used to access a particular resource file within an app package.</summary>
    /// <param name="reference">A resource map identifier that identifies the root of the new subtree. For details, see the remarks for ResourceMap class.</param>
    /// <returns>The subtree ResourceMap.</returns>
    [MethodImpl]
    public extern ResourceMap GetSubtree(string reference);

    [MethodImpl]
    public extern NamedResource Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern void Split(
      out IMapView<string, NamedResource> first,
      out IMapView<string, NamedResource> second);

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, NamedResource>> First();
  }
}
