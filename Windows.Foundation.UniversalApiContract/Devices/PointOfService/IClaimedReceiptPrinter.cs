// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedReceiptPrinter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(2597485172, 56673, 20194, 152, 55, 91, 93, 114, 213, 56, 185)]
  [ExclusiveTo(typeof (ClaimedReceiptPrinter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IClaimedReceiptPrinter
  {
    uint SidewaysMaxLines { get; }

    uint SidewaysMaxChars { get; }

    uint LinesToPaperCut { get; }

    Size PageSize { get; }

    Rect PrintArea { get; }

    ReceiptPrintJob CreateJob();
  }
}
