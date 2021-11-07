// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.WebAccountProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Security.Credentials
{
  /// <summary>Represents a web account authentication provider.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IWebAccountProviderFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WebAccountProvider : 
    IWebAccountProvider,
    IWebAccountProvider2,
    IWebAccountProvider3,
    IWebAccountProvider4
  {
    [MethodImpl]
    public extern WebAccountProvider(string id, string displayName, Uri iconUri);

    /// <summary>Gets the web account provider id.</summary>
    /// <returns>The web account provider id.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the display name for the web account provider.</summary>
    /// <returns>The display name for the web account provider.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the Uri of the icon image to display for the web account provider.</summary>
    /// <returns>The Uri of the icon image to display for the web account provider.</returns>
    public extern Uri IconUri { [Deprecated("IconUri may be altered or unavailable for releases after Windows 8.2. Instead, use Icon.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the display purpose of the web account provider.</summary>
    /// <returns>The display purpose of the web account provider.</returns>
    public extern string DisplayPurpose { [MethodImpl] get; }

    /// <summary>Gets the authority of the web account provider. Use authority to disambiguate between a single provider with multiple identities (such as a Microsoft account versus Azure Active Directory).</summary>
    /// <returns>The authority of the web account provider.</returns>
    public extern string Authority { [MethodImpl] get; }

    /// <summary>Gets the user associated with the provider.</summary>
    /// <returns>The user associated with the provider.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Gets the value describing whether the given ID provider supports system-wide authentication tokens.</summary>
    /// <returns>**True** if the WebAccountProvider allows system-wide authentication tokens. Otherwise **False**.</returns>
    public extern bool IsSystemProvider { [MethodImpl] get; }
  }
}
