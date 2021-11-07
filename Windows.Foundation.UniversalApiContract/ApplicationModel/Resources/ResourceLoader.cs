// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.ResourceLoader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.ApplicationModel.Resources
{
  /// <summary>Provides simplified access to app resources such as app UI strings.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IResourceLoaderStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IResourceLoaderStatics3), 524288, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IResourceLoaderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IResourceLoaderStatics4), 786432, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IResourceLoaderFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ResourceLoader : IResourceLoader, IResourceLoader2
  {
    /// <summary>Constructs a new ResourceLoader object for the specified ResourceMap.</summary>
    /// <param name="name">The resource identifier of the ResourceMap that the new resource loader uses for unqualified resource references. It can then retrieve resources relative to those references.</param>
    [MethodImpl]
    public extern ResourceLoader(string name);

    /// <summary>Constructs a new ResourceLoader object for the "Resources" subtree of the currently running app's main ResourceMap.</summary>
    [MethodImpl]
    public extern ResourceLoader();

    /// <summary>Returns the most appropriate string value of a resource, specified by resource identifier, for the default ResourceContext of the view in which the ResourceLoader was obtained using ResourceLoader.GetForCurrentView.</summary>
    /// <param name="resource">The resource identifier of the resource to be resolved.</param>
    /// <returns>The most appropriate string value of the specified resource for the default ResourceContext.</returns>
    [MethodImpl]
    public extern string GetString(string resource);

    [MethodImpl]
    public extern string GetStringForUri(Uri uri);

    [MethodImpl]
    public static extern string GetDefaultPriPath(string packageFullName);

    /// <summary>Gets a ResourceLoader object for the specified UIContext.</summary>
    /// <param name="context">The UI context for which to get the ResourceLoader.</param>
    /// <returns>A resource loader for the specified UIContext.</returns>
    [MethodImpl]
    public static extern ResourceLoader GetForUIContext(UIContext context);

    /// <summary>Gets a ResourceLoader object for the Resources subtree of the currently running app's main ResourceMap. This ResourceLoader uses a default context associated with the current view.</summary>
    /// <returns>A resource loader for the Resources subtree of the currently running app's main ResourceMap.</returns>
    [Overload("GetForCurrentView")]
    [MethodImpl]
    public static extern ResourceLoader GetForCurrentView();

    /// <summary>Gets a ResourceLoader object for the specified ResourceMap. This ResourceLoader uses a default context associated with the current view.</summary>
    /// <param name="name">The resource identifier of the ResourceMap that the new resource loader uses for unqualified resource references. The loader can then retrieve resources relative to those references.</param>
    /// <returns>A resource loader for the specified ResourceMap.</returns>
    [Overload("GetForCurrentViewWithName")]
    [MethodImpl]
    public static extern ResourceLoader GetForCurrentView(string name);

    /// <summary>Gets a ResourceLoader object for the Resources subtree of the currently running app's main ResourceMap. This ResourceLoader uses a default context that's not associated with any view.</summary>
    /// <returns>A resource loader for the Resources subtree of the currently running app's main ResourceMap. This ResourceLoader uses a default context that's not associated with any view. You can't use this ResourceLoader to retrieve any resource that has resource candidates qualified for scale.</returns>
    [Overload("GetForViewIndependentUse")]
    [MethodImpl]
    public static extern ResourceLoader GetForViewIndependentUse();

    /// <summary>Gets a ResourceLoader object for the specified ResourceMap. This ResourceLoader uses a default context that's not associated with any view.</summary>
    /// <param name="name">The resource identifier of the ResourceMap that the new resource loader uses for unqualified resource references. The loader can then retrieve resources relative to those references.</param>
    /// <returns>A resource loader for the Resources subtree of the currently running app's main ResourceMap. This ResourceLoader uses a default context that's not associated with any view. You can't use this ResourceLoader to retrieve any resource that has resource candidates qualified for scale.</returns>
    [Overload("GetForViewIndependentUseWithName")]
    [MethodImpl]
    public static extern ResourceLoader GetForViewIndependentUse(string name);

    [MethodImpl]
    public static extern string GetStringForReference(Uri uri);
  }
}
