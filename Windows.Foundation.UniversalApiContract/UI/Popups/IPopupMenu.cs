// Decompiled with JetBrains decompiler
// Type: Windows.UI.Popups.IPopupMenu
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Popups
{
  [ExclusiveTo(typeof (PopupMenu))]
  [Guid(1318831836, 34829, 18428, 160, 161, 114, 182, 57, 230, 37, 89)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPopupMenu
  {
    IVector<IUICommand> Commands { get; }

    IAsyncOperation<IUICommand> ShowAsync(Point invocationPoint);

    [Overload("ShowAsyncWithRect")]
    IAsyncOperation<IUICommand> ShowForSelectionAsync(Rect selection);

    [Overload("ShowAsyncWithRectAndPlacement")]
    IAsyncOperation<IUICommand> ShowForSelectionAsync(
      Rect selection,
      Placement preferredPlacement);
  }
}
