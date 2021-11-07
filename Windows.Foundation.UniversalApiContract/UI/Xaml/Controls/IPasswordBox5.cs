// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPasswordBox5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (PasswordBox))]
  [Guid(4184614739, 57812, 20802, 134, 194, 115, 24, 191, 187, 199, 5)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IPasswordBox5
  {
    bool CanPasteClipboardContent { get; }

    FlyoutBase SelectionFlyout { get; set; }

    object Description { get; set; }

    void PasteFromClipboard();
  }
}
