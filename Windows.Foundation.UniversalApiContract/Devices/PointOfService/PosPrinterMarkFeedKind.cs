// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinterMarkFeedKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Describes the ways the receipt printer station should feed the mark-sensed paper when you call the ReceiptPrintJob.MarkFeed method.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PosPrinterMarkFeedKind
  {
    /// <summary>Feeds the mark-sensed paper to the paper take-up position.</summary>
    ToTakeUp,
    /// <summary>Feeds the mark-sensed paper to the cutting position for the automatic cutter.</summary>
    ToCutter,
    /// <summary>Feeds the mark-sensed paper to the top of the form for the present paper, reverse feeding the paper if required.</summary>
    ToCurrentTopOfForm,
    /// <summary>Feeds the mark-sensed paper to the top of the form for the next paper.</summary>
    ToNextTopOfForm,
  }
}
