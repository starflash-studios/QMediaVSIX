// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationElementIdentifiersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ExclusiveTo(typeof (AutomationElementIdentifiers))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1162426783, 33600, 19815, 185, 191, 140, 42, 198, 160, 119, 58)]
  internal interface IAutomationElementIdentifiersStatics
  {
    AutomationProperty AcceleratorKeyProperty { get; }

    AutomationProperty AccessKeyProperty { get; }

    AutomationProperty AutomationIdProperty { get; }

    AutomationProperty BoundingRectangleProperty { get; }

    AutomationProperty ClassNameProperty { get; }

    AutomationProperty ClickablePointProperty { get; }

    AutomationProperty ControlTypeProperty { get; }

    AutomationProperty HasKeyboardFocusProperty { get; }

    AutomationProperty HelpTextProperty { get; }

    AutomationProperty IsContentElementProperty { get; }

    AutomationProperty IsControlElementProperty { get; }

    AutomationProperty IsEnabledProperty { get; }

    AutomationProperty IsKeyboardFocusableProperty { get; }

    AutomationProperty IsOffscreenProperty { get; }

    AutomationProperty IsPasswordProperty { get; }

    AutomationProperty IsRequiredForFormProperty { get; }

    AutomationProperty ItemStatusProperty { get; }

    AutomationProperty ItemTypeProperty { get; }

    AutomationProperty LabeledByProperty { get; }

    AutomationProperty LocalizedControlTypeProperty { get; }

    AutomationProperty NameProperty { get; }

    AutomationProperty OrientationProperty { get; }

    AutomationProperty LiveSettingProperty { get; }
  }
}
