// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarCustomToolButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an InkToolbar button that invokes a non-pen tool, defined by the host app.</summary>
  [Composable(typeof (IInkToolbarCustomToolButtonFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IInkToolbarCustomToolButtonStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public class InkToolbarCustomToolButton : InkToolbarToolButton, IInkToolbarCustomToolButton
  {
    /// <summary>Initializes a new instance of the InkToolbarCustomToolButton class.</summary>
    [MethodImpl]
    public extern InkToolbarCustomToolButton();

    /// <summary>Gets or sets the content of an optional ink stroke configuration flyout associated with the InkToolbarCustomToolButton.</summary>
    /// <returns>The contents of the flyout. The default is **null**.</returns>
    public extern UIElement ConfigurationContent { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the ConfigurationContent dependency property.</summary>
    /// <returns>The identifier for the ConfigurationContent dependency property.</returns>
    public static extern DependencyProperty ConfigurationContentProperty { [MethodImpl] get; }
  }
}
