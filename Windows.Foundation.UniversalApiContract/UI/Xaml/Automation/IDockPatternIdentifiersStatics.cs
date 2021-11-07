// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IDockPatternIdentifiersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [Guid(730276956, 60800, 20453, 142, 180, 112, 138, 57, 200, 65, 229)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DockPatternIdentifiers))]
  internal interface IDockPatternIdentifiersStatics
  {
    AutomationProperty DockPositionProperty { get; }
  }
}
