// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBoxStatics8
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (TextBox))]
  [Guid(2140395460, 32136, 24397, 137, 85, 165, 173, 56, 72, 188, 182)]
  internal interface ITextBoxStatics8
  {
    DependencyProperty CanPasteClipboardContentProperty { get; }

    DependencyProperty CanUndoProperty { get; }

    DependencyProperty CanRedoProperty { get; }

    DependencyProperty SelectionFlyoutProperty { get; }

    DependencyProperty ProofingMenuFlyoutProperty { get; }

    DependencyProperty DescriptionProperty { get; }
  }
}
