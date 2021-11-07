// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.BarcodeScannerFrameReaderFrameArrivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  /// <summary>This object is passed as a parameter to the event handlers for the BarcodeScannerFrameReader.FrameArrived event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BarcodeScannerFrameReaderFrameArrivedEventArgs : 
    IBarcodeScannerFrameReaderFrameArrivedEventArgs
  {
    /// <summary>Gets a deferral object for this operation.</summary>
    /// <returns>A Deferral object that your code uses to signal when it has finished processing the activation.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
