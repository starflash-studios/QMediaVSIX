// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.AttributedNetworkUsage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Connectivity
{
  /// <summary>Provides access to property values containing information on current usage of the attributed network connection.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AttributedNetworkUsage : IAttributedNetworkUsage
  {
    /// <summary>Gets the number of bytes sent by the app over the network.</summary>
    /// <returns>The number of bytes sent by the app.</returns>
    public extern ulong BytesSent { [MethodImpl] get; }

    /// <summary>Gets the number of bytes received by the app over the network.</summary>
    /// <returns>The number of bytes received by the app.</returns>
    public extern ulong BytesReceived { [MethodImpl] get; }

    /// <summary>Gets the Id of the of the app.</summary>
    /// <returns>The Id of the app.</returns>
    public extern string AttributionId { [MethodImpl] get; }

    /// <summary>Gets the name of the app.</summary>
    /// <returns>The name of the app.</returns>
    public extern string AttributionName { [MethodImpl] get; }

    /// <summary>Gets the thumbnail of the app.</summary>
    /// <returns>The thumbnail of the app.</returns>
    public extern IRandomAccessStreamReference AttributionThumbnail { [MethodImpl] get; }
  }
}
