// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeScannerVideoFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService.Provider
{
  [ExclusiveTo(typeof (BarcodeScannerVideoFrame))]
  [Guid(2119717448, 40439, 16673, 161, 117, 128, 29, 128, 0, 17, 46)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IBarcodeScannerVideoFrame
  {
    BitmapPixelFormat Format { get; }

    uint Width { get; }

    uint Height { get; }

    IBuffer PixelData { get; }
  }
}
