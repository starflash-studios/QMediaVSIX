// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IJournalPrinterCapabilities2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(61912645, 13240, 21307, 186, 170, 164, 56, 146, 131, 171, 10)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (JournalPrinterCapabilities))]
  internal interface IJournalPrinterCapabilities2
  {
    bool IsReverseVideoSupported { get; }

    bool IsStrikethroughSupported { get; }

    bool IsSuperscriptSupported { get; }

    bool IsSubscriptSupported { get; }

    bool IsReversePaperFeedByLineSupported { get; }

    bool IsReversePaperFeedByMapModeUnitSupported { get; }
  }
}
