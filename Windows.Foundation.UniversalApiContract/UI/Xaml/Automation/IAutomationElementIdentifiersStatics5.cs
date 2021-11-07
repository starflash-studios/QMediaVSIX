// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationElementIdentifiersStatics5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [WebHostHidden]
  [ExclusiveTo(typeof (AutomationElementIdentifiers))]
  [Guid(2557116934, 56921, 17145, 161, 231, 98, 184, 175, 158, 117, 109)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAutomationElementIdentifiersStatics5
  {
    AutomationProperty IsPeripheralProperty { get; }

    AutomationProperty IsDataValidForFormProperty { get; }

    AutomationProperty FullDescriptionProperty { get; }

    AutomationProperty DescribedByProperty { get; }

    AutomationProperty FlowsToProperty { get; }

    AutomationProperty FlowsFromProperty { get; }
  }
}
