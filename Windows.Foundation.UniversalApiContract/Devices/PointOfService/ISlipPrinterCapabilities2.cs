// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ISlipPrinterCapabilities2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(1878562417, 11546, 20480, 135, 194, 176, 133, 27, 253, 240, 126)]
  [ExclusiveTo(typeof (SlipPrinterCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface ISlipPrinterCapabilities2
  {
    bool IsReverseVideoSupported { get; }

    bool IsStrikethroughSupported { get; }

    bool IsSuperscriptSupported { get; }

    bool IsSubscriptSupported { get; }

    bool IsReversePaperFeedByLineSupported { get; }

    bool IsReversePaperFeedByMapModeUnitSupported { get; }
  }
}
