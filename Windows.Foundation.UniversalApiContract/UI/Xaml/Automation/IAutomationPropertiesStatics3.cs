// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationPropertiesStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AutomationProperties))]
  [WebHostHidden]
  [Guid(2071320373, 23729, 17069, 155, 87, 95, 171, 168, 193, 134, 127)]
  internal interface IAutomationPropertiesStatics3
  {
    DependencyProperty PositionInSetProperty { get; }

    int GetPositionInSet(DependencyObject element);

    void SetPositionInSet(DependencyObject element, int value);

    DependencyProperty SizeOfSetProperty { get; }

    int GetSizeOfSet(DependencyObject element);

    void SetSizeOfSet(DependencyObject element, int value);

    DependencyProperty LevelProperty { get; }

    int GetLevel(DependencyObject element);

    void SetLevel(DependencyObject element, int value);

    DependencyProperty AnnotationsProperty { get; }

    IVector<AutomationAnnotation> GetAnnotations(DependencyObject element);
  }
}
