// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeScannerFrameReaderFrameArrivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  [ExclusiveTo(typeof (BarcodeScannerFrameReaderFrameArrivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2965100036, 21757, 17261, 134, 41, 113, 46, 120, 114, 35, 221)]
  internal interface IBarcodeScannerFrameReaderFrameArrivedEventArgs
  {
    Deferral GetDeferral();
  }
}
