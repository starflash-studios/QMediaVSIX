// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarCustomToggleButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an InkToolbar button that sets the state of an app-defined feature to on or off. When turned on, the feature works in conjunction with the active tool.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IInkToolbarCustomToggleButtonFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  public class InkToolbarCustomToggleButton : InkToolbarToggleButton, IInkToolbarCustomToggleButton
  {
    /// <summary>Initializes a new instance of the InkToolbarCustomToggleButton class.</summary>
    [MethodImpl]
    public extern InkToolbarCustomToggleButton();
  }
}
