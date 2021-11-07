// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Inking;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InkToolbar))]
  [Guid(1037896906, 20976, 18543, 160, 62, 78, 225, 61, 193, 43, 203)]
  internal interface IInkToolbar
  {
    InkToolbarInitialControls InitialControls { get; set; }

    DependencyObjectCollection Children { get; }

    InkToolbarToolButton ActiveTool { get; set; }

    InkDrawingAttributes InkDrawingAttributes { get; }

    bool IsRulerButtonChecked { get; set; }

    InkCanvas TargetInkCanvas { get; set; }

    event TypedEventHandler<InkToolbar, object> ActiveToolChanged;

    event TypedEventHandler<InkToolbar, object> InkDrawingAttributesChanged;

    event TypedEventHandler<InkToolbar, object> EraseAllClicked;

    event TypedEventHandler<InkToolbar, object> IsRulerButtonCheckedChanged;

    InkToolbarToolButton GetToolButton(InkToolbarTool tool);

    InkToolbarToggleButton GetToggleButton(InkToolbarToggle tool);
  }
}
