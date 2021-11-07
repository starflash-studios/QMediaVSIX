// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextRegion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Media.Core
{
  [Guid(516982815, 35334, 16930, 159, 89, 178, 27, 244, 1, 36, 180)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TimedTextRegion))]
  internal interface ITimedTextRegion
  {
    string Name { get; set; }

    TimedTextPoint Position { get; set; }

    TimedTextSize Extent { get; set; }

    Color Background { get; set; }

    TimedTextWritingMode WritingMode { get; set; }

    TimedTextDisplayAlignment DisplayAlignment { get; set; }

    TimedTextDouble LineHeight { get; set; }

    bool IsOverflowClipped { get; set; }

    TimedTextPadding Padding { get; set; }

    TimedTextWrapping TextWrapping { get; set; }

    int ZIndex { get; set; }

    TimedTextScrollMode ScrollMode { get; set; }
  }
}
