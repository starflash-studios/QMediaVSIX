// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ILineDisplayCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (LineDisplayCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1511372241, 36293, 19356, 145, 114, 48, 62, 71, 183, 12, 85)]
  internal interface ILineDisplayCapabilities
  {
    bool IsStatisticsReportingSupported { get; }

    bool IsStatisticsUpdatingSupported { get; }

    UnifiedPosPowerReportingType PowerReportingType { get; }

    bool CanChangeScreenSize { get; }

    bool CanDisplayBitmaps { get; }

    bool CanReadCharacterAtCursor { get; }

    bool CanMapCharacterSets { get; }

    bool CanDisplayCustomGlyphs { get; }

    LineDisplayTextAttributeGranularity CanReverse { get; }

    LineDisplayTextAttributeGranularity CanBlink { get; }

    bool CanChangeBlinkRate { get; }

    bool IsBrightnessSupported { get; }

    bool IsCursorSupported { get; }

    bool IsHorizontalMarqueeSupported { get; }

    bool IsVerticalMarqueeSupported { get; }

    bool IsInterCharacterWaitSupported { get; }

    uint SupportedDescriptors { get; }

    uint SupportedWindows { get; }
  }
}
