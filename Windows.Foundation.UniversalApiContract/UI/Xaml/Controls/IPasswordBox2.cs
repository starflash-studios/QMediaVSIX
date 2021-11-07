// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPasswordBox2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PasswordBox))]
  [Guid(1591163103, 8495, 19179, 181, 184, 44, 33, 154, 236, 60, 12)]
  internal interface IPasswordBox2
  {
    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    string PlaceholderText { get; set; }

    SolidColorBrush SelectionHighlightColor { get; set; }

    bool PreventKeyboardDisplayOnProgrammaticFocus { get; set; }

    event TextControlPasteEventHandler Paste;
  }
}
