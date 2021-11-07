// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPasswordBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(45722129, 2887, 20093, 173, 145, 58, 65, 104, 237, 35, 13)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PasswordBox))]
  internal interface IPasswordBox
  {
    string Password { get; set; }

    string PasswordChar { get; set; }

    bool IsPasswordRevealButtonEnabled { [Deprecated("IsPasswordRevealButtonEnabledProperty may be altered or unavailable for releases after Windows 10.0. Instead, use PasswordRevealModeProperty.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("IsPasswordRevealButtonEnabledProperty may be altered or unavailable for releases after Windows 10.0. Instead, use PasswordRevealModeProperty.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }

    int MaxLength { get; set; }

    event RoutedEventHandler PasswordChanged;

    event ContextMenuOpeningEventHandler ContextMenuOpening;

    void SelectAll();
  }
}
