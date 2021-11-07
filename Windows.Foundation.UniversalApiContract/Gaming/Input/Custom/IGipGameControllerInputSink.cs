// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IGipGameControllerInputSink
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  /// <summary>Defines the methods necessary for a custom Gip controller interface.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2718993087, 2545, 17340, 161, 64, 128, 248, 153, 236, 54, 251)]
  [WebHostHidden]
  public interface IGipGameControllerInputSink : IGameControllerInputSink
  {
    /// <summary>Event raised when a key is received.</summary>
    /// <param name="timestamp">Timestamp for the event.</param>
    /// <param name="keyCode">The key code for the button that raised the event.</param>
    /// <param name="isPressed">Boolean indicating whether the key is pressed or released.</param>
    void OnKeyReceived(ulong timestamp, byte keyCode, bool isPressed);

    /// <summary>Event raised when a message is received.</summary>
    /// <param name="timestamp">Timestamp of the event.</param>
    /// <param name="messageClass">The class of the message.</param>
    /// <param name="messageId">The ID of the message.</param>
    /// <param name="sequenceId">Sequence ID of the message.</param>
    /// <param name="messageBuffer">Buffer containing the message.</param>
    void OnMessageReceived(
      ulong timestamp,
      GipMessageClass messageClass,
      byte messageId,
      byte sequenceId,
      byte[] messageBuffer);
  }
}
