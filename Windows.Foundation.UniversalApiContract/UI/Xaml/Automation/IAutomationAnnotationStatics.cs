// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationAnnotationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ExclusiveTo(typeof (AutomationAnnotation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3842239159, 20197, 18635, 181, 184, 187, 205, 70, 201, 209, 218)]
  internal interface IAutomationAnnotationStatics
  {
    DependencyProperty TypeProperty { get; }

    DependencyProperty ElementProperty { get; }
  }
}
