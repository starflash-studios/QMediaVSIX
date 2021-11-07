// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationPropertiesStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Windows.UI.Xaml.Automation
{
  [Guid(4158006869, 12570, 19324, 161, 49, 82, 78, 137, 205, 60, 249)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AutomationProperties))]
  internal interface IAutomationPropertiesStatics4
  {
    DependencyProperty LandmarkTypeProperty { get; }

    AutomationLandmarkType GetLandmarkType(DependencyObject element);

    void SetLandmarkType(DependencyObject element, AutomationLandmarkType value);

    DependencyProperty LocalizedLandmarkTypeProperty { get; }

    string GetLocalizedLandmarkType(DependencyObject element);

    void SetLocalizedLandmarkType(DependencyObject element, string value);
  }
}
