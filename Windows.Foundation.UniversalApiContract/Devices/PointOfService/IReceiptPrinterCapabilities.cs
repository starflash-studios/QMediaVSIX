// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IReceiptPrinterCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3102782863, 20904, 17404, 155, 213, 141, 226, 114, 166, 65, 91)]
  [ExclusiveTo(typeof (ReceiptPrinterCapabilities))]
  internal interface IReceiptPrinterCapabilities
  {
    bool CanCutPaper { get; }

    bool IsStampSupported { get; }

    PosPrinterMarkFeedCapabilities MarkFeedCapabilities { get; }
  }
}
