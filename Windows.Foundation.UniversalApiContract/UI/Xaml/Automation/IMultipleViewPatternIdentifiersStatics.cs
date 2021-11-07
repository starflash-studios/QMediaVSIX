// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IMultipleViewPatternIdentifiersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ExclusiveTo(typeof (MultipleViewPatternIdentifiers))]
  [Guid(2848958063, 27524, 19825, 158, 72, 215, 100, 211, 188, 218, 142)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IMultipleViewPatternIdentifiersStatics
  {
    AutomationProperty CurrentViewProperty { get; }

    AutomationProperty SupportedViewsProperty { get; }
  }
}
