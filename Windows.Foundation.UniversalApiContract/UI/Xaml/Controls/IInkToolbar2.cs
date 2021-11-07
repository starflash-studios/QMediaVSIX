// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbar2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (InkToolbar))]
  [Guid(2263925009, 46212, 17738, 174, 120, 29, 37, 163, 61, 28, 103)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IInkToolbar2
  {
    bool IsStencilButtonChecked { get; set; }

    InkToolbarButtonFlyoutPlacement ButtonFlyoutPlacement { get; set; }

    Orientation Orientation { get; set; }

    event TypedEventHandler<InkToolbar, InkToolbarIsStencilButtonCheckedChangedEventArgs> IsStencilButtonCheckedChanged;

    InkToolbarMenuButton GetMenuButton(InkToolbarMenuKind menu);
  }
}
