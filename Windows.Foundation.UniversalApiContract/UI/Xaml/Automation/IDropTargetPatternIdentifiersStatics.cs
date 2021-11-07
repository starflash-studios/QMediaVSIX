// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IDropTargetPatternIdentifiersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [WebHostHidden]
  [ExclusiveTo(typeof (DropTargetPatternIdentifiers))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(459879172, 35323, 19210, 148, 82, 202, 44, 102, 170, 249, 243)]
  internal interface IDropTargetPatternIdentifiersStatics
  {
    AutomationProperty DropTargetEffectProperty { get; }

    AutomationProperty DropTargetEffectsProperty { get; }
  }
}
