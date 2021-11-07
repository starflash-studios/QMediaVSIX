// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarToggleButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an object that provides infrastructure for both built-in and custom toggle buttons on an InkToolbar.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (IInkToolbarToggleButtonFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class InkToolbarToggleButton : CheckBox, IInkToolbarToggleButton
  {
    /// <summary>Gets the type of built-in or custom tool associated with the InkToolbarToggleButton.</summary>
    /// <returns>The type of tool.</returns>
    public extern InkToolbarToggle ToggleKind { [MethodImpl] get; }
  }
}
