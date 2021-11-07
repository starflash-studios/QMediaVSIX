// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.ISelectionPatternIdentifiersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ExclusiveTo(typeof (SelectionPatternIdentifiers))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2466470732, 27472, 16545, 178, 63, 92, 120, 221, 189, 71, 154)]
  internal interface ISelectionPatternIdentifiersStatics
  {
    AutomationProperty CanSelectMultipleProperty { get; }

    AutomationProperty IsSelectionRequiredProperty { get; }

    AutomationProperty SelectionProperty { get; }
  }
}
