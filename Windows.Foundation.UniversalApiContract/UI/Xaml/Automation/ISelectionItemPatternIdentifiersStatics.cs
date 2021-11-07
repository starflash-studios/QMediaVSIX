// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.ISelectionItemPatternIdentifiersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [Guid(2836975971, 18558, 20030, 159, 134, 123, 68, 172, 190, 39, 206)]
  [ExclusiveTo(typeof (SelectionItemPatternIdentifiers))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISelectionItemPatternIdentifiersStatics
  {
    AutomationProperty IsSelectedProperty { get; }

    AutomationProperty SelectionContainerProperty { get; }
  }
}
