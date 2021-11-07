// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationPropertiesStatics6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [WebHostHidden]
  [Guid(3323855631, 60233, 20061, 176, 18, 76, 28, 150, 195, 144, 27)]
  [ExclusiveTo(typeof (AutomationProperties))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IAutomationPropertiesStatics6
  {
    DependencyProperty CultureProperty { get; }

    int GetCulture(DependencyObject element);

    void SetCulture(DependencyObject element, int value);
  }
}
