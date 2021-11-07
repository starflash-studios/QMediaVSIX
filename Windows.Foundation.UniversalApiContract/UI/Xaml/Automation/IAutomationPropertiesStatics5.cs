// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationPropertiesStatics5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ExclusiveTo(typeof (AutomationProperties))]
  [Guid(199449382, 51449, 16802, 180, 219, 230, 167, 163, 43, 12, 52)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  internal interface IAutomationPropertiesStatics5
  {
    DependencyProperty IsPeripheralProperty { get; }

    bool GetIsPeripheral(DependencyObject element);

    void SetIsPeripheral(DependencyObject element, bool value);

    DependencyProperty IsDataValidForFormProperty { get; }

    bool GetIsDataValidForForm(DependencyObject element);

    void SetIsDataValidForForm(DependencyObject element, bool value);

    DependencyProperty FullDescriptionProperty { get; }

    string GetFullDescription(DependencyObject element);

    void SetFullDescription(DependencyObject element, string value);

    DependencyProperty LocalizedControlTypeProperty { get; }

    string GetLocalizedControlType(DependencyObject element);

    void SetLocalizedControlType(DependencyObject element, string value);

    DependencyProperty DescribedByProperty { get; }

    IVector<DependencyObject> GetDescribedBy(DependencyObject element);

    DependencyProperty FlowsToProperty { get; }

    IVector<DependencyObject> GetFlowsTo(DependencyObject element);

    DependencyProperty FlowsFromProperty { get; }

    IVector<DependencyObject> GetFlowsFrom(DependencyObject element);
  }
}
