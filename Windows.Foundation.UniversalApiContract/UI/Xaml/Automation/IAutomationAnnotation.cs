// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationAnnotation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ExclusiveTo(typeof (AutomationAnnotation))]
  [Guid(4215025866, 984, 17944, 145, 191, 228, 216, 79, 74, 243, 24)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IAutomationAnnotation
  {
    AnnotationType Type { get; set; }

    UIElement Element { get; set; }
  }
}
