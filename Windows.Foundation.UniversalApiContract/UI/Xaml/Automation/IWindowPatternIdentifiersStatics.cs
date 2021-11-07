// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IWindowPatternIdentifiersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ExclusiveTo(typeof (WindowPatternIdentifiers))]
  [WebHostHidden]
  [Guid(131116294, 25346, 19753, 135, 139, 25, 218, 3, 252, 34, 141)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWindowPatternIdentifiersStatics
  {
    AutomationProperty CanMaximizeProperty { get; }

    AutomationProperty CanMinimizeProperty { get; }

    AutomationProperty IsModalProperty { get; }

    AutomationProperty IsTopmostProperty { get; }

    AutomationProperty WindowInteractionStateProperty { get; }

    AutomationProperty WindowVisualStateProperty { get; }
  }
}
