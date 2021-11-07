// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.MediaProtectionPMPServer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  /// <summary>Represents a Protected Media Path (PMP) server to enable playback of protected content using digital rights management (DRM).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IMediaProtectionPMPServerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaProtectionPMPServer : IMediaProtectionPMPServer
  {
    /// <summary>Initializes a new instance of the MediaProtectionPMPServer class with the specified properties.</summary>
    /// <param name="pProperties">The set of properties used to initialize the server.</param>
    [MethodImpl]
    public extern MediaProtectionPMPServer(IPropertySet pProperties);

    /// <summary>Gets the property set for the MediaProtectionPMPServer.</summary>
    /// <returns>The property set for the MediaProtectionPMPServer.</returns>
    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
