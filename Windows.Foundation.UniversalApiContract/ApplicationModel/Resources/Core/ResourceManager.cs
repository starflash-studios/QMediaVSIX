// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.ResourceManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Resources.Core
{
  /// <summary>Provides access to application resource maps and more advanced resource functionality.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IResourceManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ResourceManager : IResourceManager, IResourceManager2
  {
    /// <summary>Gets the ResourceMap that is associated with the main package of the currently running application.</summary>
    /// <returns>The resource map.</returns>
    public extern ResourceMap MainResourceMap { [MethodImpl] get; }

    /// <summary>Gets a map of ResourceMap objects typically associated with the app packages, indexed by package name.</summary>
    /// <returns>Contains all default resource maps for all packages used by the app, as well as any resource maps that have been loaded explicitly.</returns>
    public extern IMapView<string, ResourceMap> AllResourceMaps { [MethodImpl] get; }

    /// <summary>Gets the default ResourceContext for the currently running application. Unless explicitly overridden, the default ResourceContext is used to determine the most appropriate representation of any given named resource.</summary>
    /// <returns>The resource context.</returns>
    public extern ResourceContext DefaultContext { [MethodImpl] get; }

    [MethodImpl]
    public extern void LoadPriFiles(IIterable<IStorageFile> files);

    [MethodImpl]
    public extern void UnloadPriFiles(IIterable<IStorageFile> files);

    /// <summary>Gets a list of all named resources for an app package.</summary>
    /// <param name="packageName">The name of the app package.</param>
    /// <param name="resourceLayoutInfo">Specifies the resource version and the named resource count.</param>
    /// <returns>A list of NamedResource objects.</returns>
    [MethodImpl]
    public extern IVectorView<NamedResource> GetAllNamedResourcesForPackage(
      string packageName,
      ResourceLayoutInfo resourceLayoutInfo);

    /// <summary>Gets a list of all collections of resource subtrees for an app package.</summary>
    /// <param name="packageName">The name of the app package.</param>
    /// <param name="resourceLayoutInfo">Specifies the resource version and the resource subtree count.</param>
    /// <returns>A list of resource subtrees (ResourceMap objects).</returns>
    [MethodImpl]
    public extern IVectorView<ResourceMap> GetAllSubtreesForPackage(
      string packageName,
      ResourceLayoutInfo resourceLayoutInfo);

    /// <summary>Gets the ResourceManager for the currently running application.</summary>
    /// <returns>The application default ResourceManager, initialized with the resources for all of the packages in the package graph.</returns>
    public static extern ResourceManager Current { [MethodImpl] get; }

    /// <summary>Determines whether a supplied string matches the resource reference format (an ms-resource string URI identifier).</summary>
    /// <param name="resourceReference">The string you want to match.</param>
    /// <returns>**TRUE** if the string matches.</returns>
    [MethodImpl]
    public static extern bool IsResourceReference(string resourceReference);
  }
}
