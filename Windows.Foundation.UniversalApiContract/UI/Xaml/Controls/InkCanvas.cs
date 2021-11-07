// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkCanvas
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Inking;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines an area that receives and displays all pen input as either an ink stroke or an erase stroke (input from an eraser tip, or the pen tip when modified with an erase button).</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IInkCanvasFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public class InkCanvas : FrameworkElement, IInkCanvas
  {
    /// <summary>Initializes a new instance of the InkCanvas class.</summary>
    [MethodImpl]
    public extern InkCanvas();

    /// <summary>Gets the underlying InkPresenter object associated with the InkCanvas.</summary>
    /// <returns>The underlying InkPresenter object.</returns>
    public extern InkPresenter InkPresenter { [MethodImpl] get; }
  }
}
