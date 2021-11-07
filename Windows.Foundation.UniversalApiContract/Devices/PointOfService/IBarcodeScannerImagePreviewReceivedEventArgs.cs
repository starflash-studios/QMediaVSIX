// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeScannerImagePreviewReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  [Guid(4088913541, 28299, 17230, 159, 88, 6, 239, 38, 188, 75, 175)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BarcodeScannerImagePreviewReceivedEventArgs))]
  internal interface IBarcodeScannerImagePreviewReceivedEventArgs
  {
    IRandomAccessStreamWithContentType Preview { get; }
  }
}
