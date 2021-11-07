// Decompiled with JetBrains decompiler
// Type: Windows.System.AppUriHandlerRegistration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Sets and retrieves dynamic AppUriHandlerHost entries for a given AppUriHandler registration.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppUriHandlerRegistration : 
    IAppUriHandlerRegistration,
    IAppUriHandlerRegistration2
  {
    /// <summary>The name of the registration.</summary>
    /// <returns>The name of the registration.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>The user context of this registration.</summary>
    /// <returns>The user context of this registration.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Retrieves the set of hosts added by SetAppAddedHostsAsync for the given registration.</summary>
    /// <returns>The set of hosts last added by SetAppAddedHostsAsync.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVector<AppUriHandlerHost>> GetAppAddedHostsAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetAppAddedHostsAsync(IIterable<AppUriHandlerHost> hosts);

    [MethodImpl]
    public extern IVector<AppUriHandlerHost> GetAllHosts();

    [MethodImpl]
    public extern void UpdateHosts(IIterable<AppUriHandlerHost> hosts);

    public extern string PackageFamilyName { [MethodImpl] get; }
  }
}
