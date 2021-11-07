// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationAnnotationFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [Guid(1225194066, 56768, 20073, 183, 107, 1, 157, 146, 141, 130, 47)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AutomationAnnotation))]
  internal interface IAutomationAnnotationFactory
  {
    AutomationAnnotation CreateInstance(AnnotationType type);

    AutomationAnnotation CreateWithElementParameter(
      AnnotationType type,
      UIElement element);
  }
}
