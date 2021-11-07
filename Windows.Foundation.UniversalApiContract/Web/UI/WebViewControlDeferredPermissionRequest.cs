// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.WebViewControlDeferredPermissionRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI
{
  /// <summary>Represents a deferred request for permissions in an IWebViewControl.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class WebViewControlDeferredPermissionRequest : 
    IWebViewControlDeferredPermissionRequest
  {
    /// <summary>Gets the identifier for the permission request.</summary>
    /// <returns>The identifier for the permission request.</returns>
    public extern uint Id { [MethodImpl] get; }

    /// <summary>Gets the Uniform Resource Identifier (URI) of the content where the permission request originated.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the content where the permission request originated.</returns>
    public extern Uri Uri { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the type of permission that's requested.</summary>
    /// <returns>An enumeration value that indicates the type of permission requested.</returns>
    public extern WebViewControlPermissionType PermissionType { [MethodImpl] get; }

    /// <summary>Grants the requested permission.</summary>
    [MethodImpl]
    public extern void Allow();

    /// <summary>Denies the requested permission.</summary>
    [MethodImpl]
    public extern void Deny();
  }
}
