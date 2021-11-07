// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IXusbGameControllerInputSink
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  /// <summary>Defines the methods necessary for a custom Xusb controller interface.</summary>
  [Guid(2997624213, 28363, 17075, 138, 171, 2, 84, 1, 202, 71, 18)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  public interface IXusbGameControllerInputSink : IGameControllerInputSink
  {
    /// <summary>Event raised when input is received.</summary>
    /// <param name="timestamp">Timestamp of the event.</param>
    /// <param name="reportId">ID of the report.</param>
    /// <param name="inputBuffer">Buffer containing the received input.</param>
    void OnInputReceived(ulong timestamp, byte reportId, byte[] inputBuffer);
  }
}
