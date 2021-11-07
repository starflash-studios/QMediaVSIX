// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IRangeValuePatternIdentifiersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [Guid(3458417935, 7207, 17791, 184, 21, 122, 94, 70, 134, 61, 187)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RangeValuePatternIdentifiers))]
  [WebHostHidden]
  internal interface IRangeValuePatternIdentifiersStatics
  {
    AutomationProperty IsReadOnlyProperty { get; }

    AutomationProperty LargeChangeProperty { get; }

    AutomationProperty MaximumProperty { get; }

    AutomationProperty MinimumProperty { get; }

    AutomationProperty SmallChangeProperty { get; }

    AutomationProperty ValueProperty { get; }
  }
}
