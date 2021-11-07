// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2828083811, 10577, 20312, 169, 197, 90, 19, 78, 170, 127, 7)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Control))]
  internal interface IControl
  {
    double FontSize { get; set; }

    FontFamily FontFamily { get; set; }

    FontWeight FontWeight { get; set; }

    FontStyle FontStyle { get; set; }

    FontStretch FontStretch { get; set; }

    int CharacterSpacing { get; set; }

    Brush Foreground { get; set; }

    bool IsTabStop { get; set; }

    bool IsEnabled { get; set; }

    int TabIndex { get; set; }

    KeyboardNavigationMode TabNavigation { get; set; }

    ControlTemplate Template { get; set; }

    Thickness Padding { get; set; }

    HorizontalAlignment HorizontalContentAlignment { get; set; }

    VerticalAlignment VerticalContentAlignment { get; set; }

    Brush Background { get; set; }

    Thickness BorderThickness { get; set; }

    Brush BorderBrush { get; set; }

    FocusState FocusState { get; }

    event DependencyPropertyChangedEventHandler IsEnabledChanged;

    bool ApplyTemplate();

    bool Focus(FocusState value);
  }
}
