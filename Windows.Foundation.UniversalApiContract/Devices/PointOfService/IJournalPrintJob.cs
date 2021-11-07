// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IJournalPrintJob
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(2672765028, 62448, 21968, 140, 57, 116, 204, 145, 120, 62, 237)]
  [ExclusiveTo(typeof (JournalPrintJob))]
  internal interface IJournalPrintJob
  {
    void Print(string data, PosPrinterPrintOptions printOptions);

    void FeedPaperByLine(int lineCount);

    void FeedPaperByMapModeUnit(int distance);
  }
}
