// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBox8
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2694373560, 6370, 20798, 157, 141, 78, 151, 3, 65, 12, 3)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RichEditBox))]
  internal interface IRichEditBox8
  {
    RichEditTextDocument TextDocument { get; }

    FlyoutBase SelectionFlyout { get; set; }

    FlyoutBase ProofingMenuFlyout { get; }

    object Description { get; set; }

    event TypedEventHandler<RichEditBox, RichEditBoxSelectionChangingEventArgs> SelectionChanging;
  }
}
