// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextStyle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (TimedTextStyle))]
  [Guid(464664653, 43045, 16578, 167, 245, 40, 30, 174, 223, 59, 85)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITimedTextStyle
  {
    string Name { get; set; }

    string FontFamily { get; set; }

    TimedTextDouble FontSize { get; set; }

    TimedTextWeight FontWeight { get; set; }

    Color Foreground { get; set; }

    Color Background { get; set; }

    bool IsBackgroundAlwaysShown { get; set; }

    TimedTextFlowDirection FlowDirection { get; set; }

    TimedTextLineAlignment LineAlignment { get; set; }

    Color OutlineColor { get; set; }

    TimedTextDouble OutlineThickness { get; set; }

    TimedTextDouble OutlineRadius { get; set; }
  }
}
