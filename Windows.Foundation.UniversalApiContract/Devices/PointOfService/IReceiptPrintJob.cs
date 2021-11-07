// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IReceiptPrintJob
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (ReceiptPrintJob))]
  [Guid(2861958766, 44205, 19321, 157, 15, 192, 207, 192, 141, 199, 123)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IReceiptPrintJob
  {
    void MarkFeed(PosPrinterMarkFeedKind kind);

    [Overload("CutPaper")]
    void CutPaper(double percentage);

    [Overload("CutPaperDefault")]
    void CutPaper();
  }
}
