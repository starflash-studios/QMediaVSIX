﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IReceiptPrintJob2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(213652195, 40489, 20857, 188, 216, 24, 17, 211, 185, 161, 14)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (ReceiptPrintJob))]
  internal interface IReceiptPrintJob2
  {
    void StampPaper();

    void Print(string data, PosPrinterPrintOptions printOptions);

    void FeedPaperByLine(int lineCount);

    void FeedPaperByMapModeUnit(int distance);
  }
}