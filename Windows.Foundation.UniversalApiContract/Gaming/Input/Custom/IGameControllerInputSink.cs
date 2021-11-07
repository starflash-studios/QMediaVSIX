// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IGameControllerInputSink
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  /// <summary>Base interface that defines the interfaces necessary to write a custom game controller class.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(536279330, 50752, 19576, 168, 32, 154, 113, 92, 85, 139, 203)]
  [WebHostHidden]
  public interface IGameControllerInputSink
  {
    /// <summary>Event raised when input for the controller is resumed.</summary>
    /// <param name="timestamp">Timestamp for the event.</param>
    void OnInputResumed(ulong timestamp);

    /// <summary>Event raised when input for the controller is suspended.</summary>
    /// <param name="timestamp">Timestamp of the event.</param>
    void OnInputSuspended(ulong timestamp);
  }
}
