// Decompiled with JetBrains decompiler
// Type: Windows.Media.ISystemMediaTransportControlsTimelineProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ExclusiveTo(typeof (SystemMediaTransportControlsTimelineProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1361391978, 50082, 18267, 133, 7, 147, 83, 77, 200, 143, 21)]
  internal interface ISystemMediaTransportControlsTimelineProperties
  {
    TimeSpan StartTime { get; set; }

    TimeSpan EndTime { get; set; }

    TimeSpan MinSeekTime { get; set; }

    TimeSpan MaxSeekTime { get; set; }

    TimeSpan Position { get; set; }
  }
}
