// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationPropertiesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Windows.UI.Xaml.Automation
{
  [Guid(3055091067, 13008, 18800, 156, 66, 124, 3, 154, 199, 190, 120)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AutomationProperties))]
  internal interface IAutomationPropertiesStatics
  {
    DependencyProperty AcceleratorKeyProperty { get; }

    string GetAcceleratorKey(DependencyObject element);

    void SetAcceleratorKey(DependencyObject element, string value);

    DependencyProperty AccessKeyProperty { get; }

    string GetAccessKey(DependencyObject element);

    void SetAccessKey(DependencyObject element, string value);

    DependencyProperty AutomationIdProperty { get; }

    string GetAutomationId(DependencyObject element);

    void SetAutomationId(DependencyObject element, string value);

    DependencyProperty HelpTextProperty { get; }

    string GetHelpText(DependencyObject element);

    void SetHelpText(DependencyObject element, string value);

    DependencyProperty IsRequiredForFormProperty { get; }

    bool GetIsRequiredForForm(DependencyObject element);

    void SetIsRequiredForForm(DependencyObject element, bool value);

    DependencyProperty ItemStatusProperty { get; }

    string GetItemStatus(DependencyObject element);

    void SetItemStatus(DependencyObject element, string value);

    DependencyProperty ItemTypeProperty { get; }

    string GetItemType(DependencyObject element);

    void SetItemType(DependencyObject element, string value);

    DependencyProperty LabeledByProperty { get; }

    UIElement GetLabeledBy(DependencyObject element);

    void SetLabeledBy(DependencyObject element, UIElement value);

    DependencyProperty NameProperty { get; }

    string GetName(DependencyObject element);

    void SetName(DependencyObject element, string value);

    DependencyProperty LiveSettingProperty { get; }

    AutomationLiveSetting GetLiveSetting(DependencyObject element);

    void SetLiveSetting(DependencyObject element, AutomationLiveSetting value);
  }
}
