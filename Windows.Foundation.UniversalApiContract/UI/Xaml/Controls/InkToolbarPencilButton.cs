// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarPencilButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an InkToolbar toggle button control that activates the built-in pencil.</summary>
  [Composable(typeof (IInkToolbarPencilButtonFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public class InkToolbarPencilButton : InkToolbarPenButton, IInkToolbarPencilButton
  {
    /// <summary>Initializes a new instance of the InkToolbarPencilButton class.</summary>
    [MethodImpl]
    public extern InkToolbarPencilButton();
  }
}
