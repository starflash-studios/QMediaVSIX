// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IGridItemPatternIdentifiersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(561849346, 24134, 19809, 135, 148, 184, 238, 142, 119, 71, 20)]
  [ExclusiveTo(typeof (GridItemPatternIdentifiers))]
  internal interface IGridItemPatternIdentifiersStatics
  {
    AutomationProperty ColumnProperty { get; }

    AutomationProperty ColumnSpanProperty { get; }

    AutomationProperty ContainingGridProperty { get; }

    AutomationProperty RowProperty { get; }

    AutomationProperty RowSpanProperty { get; }
  }
}
