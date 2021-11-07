// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationElementIdentifiersStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AutomationElementIdentifiers))]
  [WebHostHidden]
  [Guid(257736381, 46059, 16515, 173, 199, 12, 47, 57, 187, 53, 67)]
  internal interface IAutomationElementIdentifiersStatics3
  {
    AutomationProperty PositionInSetProperty { get; }

    AutomationProperty SizeOfSetProperty { get; }

    AutomationProperty LevelProperty { get; }

    AutomationProperty AnnotationsProperty { get; }
  }
}
