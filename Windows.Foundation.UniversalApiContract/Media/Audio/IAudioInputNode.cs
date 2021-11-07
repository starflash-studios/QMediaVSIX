// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioInputNode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Defines an audio input node.</summary>
  [Guid(3511156828, 33832, 18308, 183, 253, 169, 157, 70, 140, 93, 32)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IAudioInputNode : IAudioNode, IClosable
  {
    /// <summary>Gets outgoing connections for the audio input node.</summary>
    /// <returns>A collection of audio graph connection objects representing the outgoing connections.</returns>
    IVectorView<AudioGraphConnection> OutgoingConnections { get; }

    /// <summary>Adds an outgoing connection to the audio input node.</summary>
    /// <param name="destination">The destination node for the connection.</param>
    [Overload("AddOutgoingConnection")]
    void AddOutgoingConnection(IAudioNode destination);

    /// <summary>Adds an outgoing connection with gain to the audio input node.</summary>
    /// <param name="destination">The destination node for the connection.</param>
    /// <param name="gain">A value indicating the gain associated with the connection.</param>
    [Overload("AddOutgoingConnectionWithGain")]
    void AddOutgoingConnection(IAudioNode destination, double gain);

    /// <summary>Removes the outgoing connection from the audio input node to the specified node.</summary>
    /// <param name="destination">The audio node for which the outgoing connection is removed.</param>
    void RemoveOutgoingConnection(IAudioNode destination);
  }
}
