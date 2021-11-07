// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IValuePatternIdentifiersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [Guid(3259492599, 44492, 17423, 177, 35, 51, 120, 138, 64, 82, 90)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ValuePatternIdentifiers))]
  [WebHostHidden]
  internal interface IValuePatternIdentifiersStatics
  {
    AutomationProperty IsReadOnlyProperty { get; }

    AutomationProperty ValueProperty { get; }
  }
}
