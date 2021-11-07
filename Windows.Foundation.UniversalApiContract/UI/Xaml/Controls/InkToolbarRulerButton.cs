// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarRulerButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Inking;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an InkToolbar button that sets the state of the built-in ruler tool to on or off.</summary>
  /// <deprecated type="deprecate">InkToolbarRulerButton is deprecated starting from Windows 10 Creators Update. Please use InkToolbarStencilButton going forward. For more info, see MSDN.</deprecated>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Composable(typeof (IInkToolbarRulerButtonFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IInkToolbarRulerButtonStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Deprecated("InkToolbarRulerButton is deprecated starting from Windows 10 Creators Update. Please use InkToolbarStencilButton going forward. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  public class InkToolbarRulerButton : InkToolbarToggleButton, IInkToolbarRulerButton
  {
    /// <summary>Initializes a new instance of the InkToolbarRulerButton class.</summary>
    /// <deprecated type="deprecate">InkToolbarRulerButton is deprecated starting from Windows 10 Creators Update. Please use InkToolbarStencilButton going forward. For more info, see MSDN.</deprecated>
    [Deprecated("InkToolbarRulerButton is deprecated starting from Windows 10 Creators Update. Please use InkToolbarStencilButton going forward. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern InkToolbarRulerButton();

    /// <summary>Gets the stencil associated with the InkToolbarRulerButton.</summary>
    /// <returns>The stencil associated with the InkToolbarRulerButton.</returns>
    public extern InkPresenterRuler Ruler { [Deprecated("InkToolbarRulerButton is deprecated starting from Windows 10 Creators Update. Please use InkToolbarStencilButton going forward. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Identifies the Ruler dependency property.</summary>
    /// <returns>The identifier for the Ruler dependency property.</returns>
    public static extern DependencyProperty RulerProperty { [Deprecated("InkToolbarRulerButton is deprecated starting from Windows 10 Creators Update. Please use InkToolbarStencilButton going forward. For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
