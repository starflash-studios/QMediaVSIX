// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarIsStencilButtonCheckedChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the IsStencilButtonCheckedChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class InkToolbarIsStencilButtonCheckedChangedEventArgs : 
    IInkToolbarIsStencilButtonCheckedChangedEventArgs
  {
    /// <summary>Initializes a new instance of the InkToolbarIsStencilButtonCheckedChangedEventArgs class.</summary>
    [MethodImpl]
    public extern InkToolbarIsStencilButtonCheckedChangedEventArgs();

    /// <summary>Gets the button for the selected stencil.</summary>
    /// <returns>The stencil button.</returns>
    public extern InkToolbarStencilButton StencilButton { [MethodImpl] get; }

    /// <summary>Gets the type of stencil.</summary>
    /// <returns>The type of stencil.</returns>
    public extern InkToolbarStencilKind StencilKind { [MethodImpl] get; }
  }
}
