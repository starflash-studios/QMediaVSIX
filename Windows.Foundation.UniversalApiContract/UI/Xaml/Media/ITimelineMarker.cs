// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ITimelineMarker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(2794385453, 17850, 20048, 140, 173, 170, 234, 58, 34, 122, 245)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TimelineMarker))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITimelineMarker
  {
    TimeSpan Time { get; set; }

    string Type { get; set; }

    string Text { get; set; }
  }
}
