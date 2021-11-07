// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.NamedResource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  /// <summary>Represents a single logical, named resource, such as a string resource named 'Header1'.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class NamedResource : INamedResource
  {
    /// <summary>Gets a URI that can be used to refer to this named resource.</summary>
    /// <returns>A URI that can be used to refer to this named resource. See [URI schemes](https://docs.microsoft.com/previous-versions/windows/apps/jj655406(v=win.10)) for information on identifying resources.</returns>
    public extern Uri Uri { [MethodImpl] get; }

    /// <summary>Gets all possible candidate values for this named resource.</summary>
    /// <returns>A set of ResourceCandidate objects, each of which describes one possible value for this named resource and the qualifiers under which it applies.</returns>
    public extern IVectorView<ResourceCandidate> Candidates { [MethodImpl] get; }

    /// <summary>Resolves this NamedResource object against the default context and returns the most appropriate candidate.</summary>
    /// <returns>The most appropriate candidate for the default context.</returns>
    [Overload("Resolve")]
    [MethodImpl]
    public extern ResourceCandidate Resolve();

    /// <summary>Resolves this NamedResource object against a supplied context and returns the most appropriate candidate.</summary>
    /// <param name="resourceContext">The context against which the NamedResource should be resolved.</param>
    /// <returns>The most appropriate candidate for the specified context.</returns>
    [Overload("ResolveForContext")]
    [MethodImpl]
    public extern ResourceCandidate Resolve(ResourceContext resourceContext);

    /// <summary>Resolves this NamedResource object against the default context and returns a list of all possible candidates in preference order.</summary>
    /// <returns>A list of ResourceCandidate objects, in order of preference. The object in first position in the list is the most appropriate candidate for the corresponding context, and the object in last position is the least appropriate.</returns>
    [Overload("ResolveAll")]
    [MethodImpl]
    public extern IVectorView<ResourceCandidate> ResolveAll();

    /// <summary>Resolves this NamedResource object against a supplied context and returns a list of all possible candidates in preference order.</summary>
    /// <param name="resourceContext">The context against which the NamedResource should be resolved.</param>
    /// <returns>A list of ResourceCandidate objects, in order of preference. The object in first position in the list is the most appropriate candidate for the corresponding context, and the object in last position is the least appropriate.</returns>
    [Overload("ResolveAllForContext")]
    [MethodImpl]
    public extern IVectorView<ResourceCandidate> ResolveAll(
      ResourceContext resourceContext);
  }
}
