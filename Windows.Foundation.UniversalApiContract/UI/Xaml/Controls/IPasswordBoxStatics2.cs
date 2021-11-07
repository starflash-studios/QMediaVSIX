// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPasswordBoxStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (PasswordBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4233597791, 39162, 16486, 183, 133, 250, 114, 94, 205, 226, 50)]
  [WebHostHidden]
  internal interface IPasswordBoxStatics2
  {
    DependencyProperty HeaderProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }

    DependencyProperty PlaceholderTextProperty { get; }

    DependencyProperty SelectionHighlightColorProperty { get; }

    DependencyProperty PreventKeyboardDisplayOnProgrammaticFocusProperty { get; }
  }
}
