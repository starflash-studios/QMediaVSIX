// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.BarcodeScannerVideoFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService.Provider
{
  /// <summary>Represents data from a video frame that was acquired by using a BarcodeScannerFrameReader.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class BarcodeScannerVideoFrame : IBarcodeScannerVideoFrame, IClosable
  {
    /// <summary>Gets the format of the video frame.</summary>
    /// <returns>The format of the video frame as a BitmapPixelFormat object.</returns>
    public extern BitmapPixelFormat Format { [MethodImpl] get; }

    /// <summary>Gets the width of the video frame.</summary>
    /// <returns>The width of the video frame in pixels.</returns>
    public extern uint Width { [MethodImpl] get; }

    /// <summary>Gets the height of the video frame.</summary>
    /// <returns>The height of the video frame in pixels.</returns>
    public extern uint Height { [MethodImpl] get; }

    /// <summary>Gets the pixel data of the video frame.</summary>
    /// <returns>The pixel data as an IBuffer.</returns>
    public extern IBuffer PixelData { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
