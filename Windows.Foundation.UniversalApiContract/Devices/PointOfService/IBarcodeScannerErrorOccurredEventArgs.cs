// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeScannerErrorOccurredEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BarcodeScannerErrorOccurredEventArgs))]
  [Guid(751984687, 53050, 16386, 167, 90, 197, 236, 70, 143, 10, 32)]
  internal interface IBarcodeScannerErrorOccurredEventArgs
  {
    BarcodeScannerReport PartialInputData { get; }

    bool IsRetriable { get; }

    UnifiedPosErrorData ErrorData { get; }
  }
}
