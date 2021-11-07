// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationPropertiesStatics9
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Windows.UI.Xaml.Automation
{
  [Guid(790671825, 34738, 21858, 128, 119, 218, 89, 62, 218, 253, 45)]
  [ExclusiveTo(typeof (AutomationProperties))]
  [ContractVersion(typeof (UniversalApiContract), 917504)]
  [WebHostHidden]
  internal interface IAutomationPropertiesStatics9
  {
    DependencyProperty AutomationControlTypeProperty { get; }

    AutomationControlType GetAutomationControlType(UIElement element);

    void SetAutomationControlType(UIElement element, AutomationControlType value);
  }
}
