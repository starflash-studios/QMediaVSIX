// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IGridPatternIdentifiersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2076463859, 41345, 16695, 141, 233, 31, 155, 26, 131, 32, 237)]
  [ExclusiveTo(typeof (GridPatternIdentifiers))]
  [WebHostHidden]
  internal interface IGridPatternIdentifiersStatics
  {
    AutomationProperty ColumnCountProperty { get; }

    AutomationProperty RowCountProperty { get; }
  }
}
