// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IHidGameControllerInputSink
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  /// <summary>Defines the methods necessary for a custom HID (Human Interface Device) controller interface.</summary>
  [Guid(4149527330, 6189, 16612, 161, 38, 252, 238, 79, 250, 30, 49)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public interface IHidGameControllerInputSink : IGameControllerInputSink
  {
    /// <summary>Event raised when input is received.</summary>
    /// <param name="timestamp">Timestamp of the event.</param>
    /// <param name="reportId">The ID of the report.</param>
    /// <param name="reportBuffer">Buffer containing the received input.</param>
    void OnInputReportReceived(ulong timestamp, byte reportId, byte[] reportBuffer);
  }
}
