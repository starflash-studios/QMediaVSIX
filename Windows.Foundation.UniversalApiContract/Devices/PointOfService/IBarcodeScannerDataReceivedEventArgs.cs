// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeScannerDataReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (BarcodeScannerDataReceivedEventArgs))]
  [Guid(1110747106, 60823, 18045, 173, 43, 1, 228, 67, 19, 169, 41)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBarcodeScannerDataReceivedEventArgs
  {
    BarcodeScannerReport Report { get; }
  }
}
