// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarEraserButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an InkToolbar button that activates the built-in eraser tool.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IInkToolbarEraserButtonStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Composable(typeof (IInkToolbarEraserButtonFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public class InkToolbarEraserButton : 
    InkToolbarToolButton,
    IInkToolbarEraserButton,
    IInkToolbarEraserButton2
  {
    /// <summary>Initializes a new instance of the InkToolbarEraserButton class.</summary>
    [MethodImpl]
    public extern InkToolbarEraserButton();

    /// <summary>Gets or sets whether the "Erase all ink" button is visible.</summary>
    /// <returns>**true** if visible. Otherwise, **false**.</returns>
    public extern bool IsClearAllVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the IsClearAllVisible dependency property.</summary>
    /// <returns>The identifier for the IsClearAllVisible dependency property.</returns>
    public static extern DependencyProperty IsClearAllVisibleProperty { [MethodImpl] get; }
  }
}
