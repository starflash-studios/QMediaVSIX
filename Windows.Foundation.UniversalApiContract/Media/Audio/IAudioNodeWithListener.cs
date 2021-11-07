// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeWithListener
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>The interface implemented by audio nodes that support a spatial audio listener.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(235901052, 31231, 17732, 158, 235, 1, 37, 123, 21, 16, 90)]
  public interface IAudioNodeWithListener : IClosable, IAudioNode
  {
    /// <summary>Gets or sets the AudioNodeListener that describes the position and other characteristics of the listener from which the node's audio is heard when spatial audio processing is used.</summary>
    /// <returns>The listener for the audio node.</returns>
    AudioNodeListener Listener { set; get; }
  }
}
