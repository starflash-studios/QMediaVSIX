// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarStencilButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Inking;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an InkToolbar button that sets the state of stencil tool to on or off.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IInkToolbarStencilButtonStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IInkToolbarStencilButtonFactory), CompositionType.Public, 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public class InkToolbarStencilButton : InkToolbarMenuButton, IInkToolbarStencilButton
  {
    /// <summary>Initializes a new instance of the InkToolbarStencilButton class.</summary>
    [MethodImpl]
    public extern InkToolbarStencilButton();

    /// <summary>Gets a reference to the ruler tool of the InkPresenter object.</summary>
    /// <returns>The ruler tool.</returns>
    public extern InkPresenterRuler Ruler { [MethodImpl] get; }

    /// <summary>Gets a reference to the protractor tool of the InkPresenter object.</summary>
    /// <returns>The protractor tool.</returns>
    public extern InkPresenterProtractor Protractor { [MethodImpl] get; }

    /// <summary>Gets or sets the selected stencil button.</summary>
    /// <returns>The selected stencil button.</returns>
    public extern InkToolbarStencilKind SelectedStencil { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the built-in ruler stencil button is visible.</summary>
    /// <returns>**true** if visible. Otherwise, **false**.</returns>
    public extern bool IsRulerItemVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the built-in protractor stencil button is visible.</summary>
    /// <returns>**true** if visible. Otherwise, **false**.</returns>
    public extern bool IsProtractorItemVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Ruler dependency property.</summary>
    /// <returns>The identifier for the Ruler dependency property.</returns>
    public static extern DependencyProperty RulerProperty { [MethodImpl] get; }

    /// <summary>Identifies the Protractor dependency property.</summary>
    /// <returns>The identifier for the Protractor dependency property.</returns>
    public static extern DependencyProperty ProtractorProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedStencil dependency property.</summary>
    /// <returns>The identifier for the SelectedStencil dependency property.</returns>
    public static extern DependencyProperty SelectedStencilProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsRulerItemVisible dependency property.</summary>
    /// <returns>The identifier for the IsRulerItemVisible dependency property.</returns>
    public static extern DependencyProperty IsRulerItemVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsProtractorItemVisible dependency property.</summary>
    /// <returns>The identifier for the IsProtractorItemVisible dependency property.</returns>
    public static extern DependencyProperty IsProtractorItemVisibleProperty { [MethodImpl] get; }
  }
}
