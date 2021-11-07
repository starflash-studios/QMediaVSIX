// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.ProtectionCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  /// <summary>Exposes Microsoft PlayReady digital rights management (DRM) capabilities for video decoding, video display, and video output protection subsystems used by the Windows Media Foundation pipeline under a XAML MediaElement or  C++ Media Engine to a WinRT caller.  The caller may use this information to select the most appropriate encoding of DRM’ed content for playback.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [DualApiPartition(version = 167772160)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ProtectionCapabilities : IProtectionCapabilities
  {
    /// <summary>Initializes a new instance of the **ProtectionCapabilities** class.</summary>
    [MethodImpl]
    public extern ProtectionCapabilities();

    /// <summary>Queries features of video decoding, display, and output protection subsystems for DRM capabilities.</summary>
    /// <param name="type">String identifying the features for which support is queried queried. This parameter accepts RFC 2045 Content-Type strings to specify media type and subtype identifiers, and RFC 6381 Codecs identifiers for the codecs required. These base strings are consistent with those used in the HTML5 **HTMLMediaElement** **canPlayType** method. RFC 2045 allows for additional, custom parameters as modifiers in the form of `";&lt;parameter&gt;=&lt;name&gt;[=&lt;value&gt;] [,&lt;name&gt;[=&lt;value&gt;]"`.</param>
    /// <param name="keySystem">A string identifying the PlayReady namespace to check query against, specifying hardware or software protection. Use "com.microsoft.playready.hardware" for hardware queries (PlayReady must have support for hardware offload), "com.microsoft.playready.software" for explicitly querying for software protection support, and "com.microsoft.playready" for general queries (must answer for software protection support to guarantee backward compatibility).</param>
    /// <returns>A value indicating if the queried capabilities are likely supported, are possibly supported, or are unsupported.</returns>
    [MethodImpl]
    public extern ProtectionCapabilityResult IsTypeSupported(
      string type,
      string keySystem);
  }
}
