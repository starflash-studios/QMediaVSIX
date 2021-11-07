// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationPropertiesStatics7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Windows.UI.Xaml.Automation
{
  [Guid(4159278067, 36753, 16488, 164, 173, 183, 180, 2, 209, 10, 44)]
  [ExclusiveTo(typeof (AutomationProperties))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IAutomationPropertiesStatics7
  {
    DependencyProperty HeadingLevelProperty { get; }

    AutomationHeadingLevel GetHeadingLevel(DependencyObject element);

    void SetHeadingLevel(DependencyObject element, AutomationHeadingLevel value);
  }
}
