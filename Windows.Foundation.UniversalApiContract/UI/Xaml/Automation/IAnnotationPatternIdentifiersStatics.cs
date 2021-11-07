// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAnnotationPatternIdentifiersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [Guid(3773014877, 53607, 18140, 149, 171, 51, 10, 246, 26, 235, 181)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AnnotationPatternIdentifiers))]
  internal interface IAnnotationPatternIdentifiersStatics
  {
    AutomationProperty AnnotationTypeIdProperty { get; }

    AutomationProperty AnnotationTypeNameProperty { get; }

    AutomationProperty AuthorProperty { get; }

    AutomationProperty DateTimeProperty { get; }

    AutomationProperty TargetProperty { get; }
  }
}
