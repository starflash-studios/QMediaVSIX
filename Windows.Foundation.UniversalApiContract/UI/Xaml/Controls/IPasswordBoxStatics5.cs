// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPasswordBoxStatics5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(1272627628, 27458, 22003, 191, 164, 101, 199, 35, 80, 120, 214)]
  [ExclusiveTo(typeof (PasswordBox))]
  [WebHostHidden]
  internal interface IPasswordBoxStatics5
  {
    DependencyProperty CanPasteClipboardContentProperty { get; }

    DependencyProperty SelectionFlyoutProperty { get; }

    DependencyProperty DescriptionProperty { get; }
  }
}
