// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IScrollPatternIdentifiersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ScrollPatternIdentifiers))]
  [Guid(1274601633, 64383, 20388, 131, 179, 207, 174, 177, 3, 166, 133)]
  internal interface IScrollPatternIdentifiersStatics
  {
    AutomationProperty HorizontallyScrollableProperty { get; }

    AutomationProperty HorizontalScrollPercentProperty { get; }

    AutomationProperty HorizontalViewSizeProperty { get; }

    double NoScroll { get; }

    AutomationProperty VerticallyScrollableProperty { get; }

    AutomationProperty VerticalScrollPercentProperty { get; }

    AutomationProperty VerticalViewSizeProperty { get; }
  }
}
