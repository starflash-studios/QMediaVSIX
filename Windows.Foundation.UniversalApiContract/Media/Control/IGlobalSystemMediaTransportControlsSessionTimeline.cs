// Decompiled with JetBrains decompiler
// Type: Windows.Media.Control.IGlobalSystemMediaTransportControlsSessionTimelineProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Control
{
  [Guid(3991093558, 28453, 22669, 142, 207, 234, 91, 103, 53, 170, 165)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (GlobalSystemMediaTransportControlsSessionTimelineProperties))]
  internal interface IGlobalSystemMediaTransportControlsSessionTimelineProperties
  {
    TimeSpan StartTime { get; }

    TimeSpan EndTime { get; }

    TimeSpan MinSeekTime { get; }

    TimeSpan MaxSeekTime { get; }

    TimeSpan Position { get; }

    DateTime LastUpdatedTime { get; }
  }
}
