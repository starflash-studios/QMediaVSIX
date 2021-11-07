// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.AppBarTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides calculated values that can be referenced as **TemplatedParent** sources when defining templates for an AppBar control. Not intended for general use.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppBarTemplateSettings : 
    DependencyObject,
    IAppBarTemplateSettings,
    IAppBarTemplateSettings2
  {
    /// <summary>Gets the Rect that describes the clipped area of the AppBar.</summary>
    /// <returns>A Rect that describes the clipped area of the AppBar.</returns>
    public extern Rect ClipRect { [MethodImpl] get; }

    /// <summary>Gets the vertical delta of the AppBar in the compact state.</summary>
    /// <returns>The vertical delta of the AppBar in the compact state.</returns>
    public extern double CompactVerticalDelta { [MethodImpl] get; }

    /// <summary>Gets the margin of the AppBar root in the compact state.</summary>
    /// <returns>The margin of the AppBar root in the compact state.</returns>
    public extern Thickness CompactRootMargin { [MethodImpl] get; }

    /// <summary>Gets the vertical delta of the AppBar in the minimal state.</summary>
    /// <returns>The vertical delta of the AppBar in the minimal state.</returns>
    public extern double MinimalVerticalDelta { [MethodImpl] get; }

    /// <summary>Gets the margin of the AppBar root in the minimal state.</summary>
    /// <returns>The margin of the AppBar root in the minimal state.</returns>
    public extern Thickness MinimalRootMargin { [MethodImpl] get; }

    /// <summary>Gets the vertical delta of the AppBar in the hidden state.</summary>
    /// <returns>The vertical delta of the AppBar in the hidden state.</returns>
    public extern double HiddenVerticalDelta { [MethodImpl] get; }

    /// <summary>Gets the margin of the AppBar root in the hidden state.</summary>
    /// <returns>The margin of the AppBar root in the hidden state.</returns>
    public extern Thickness HiddenRootMargin { [MethodImpl] get; }

    /// <summary>Gets the negative vertical delta of the AppBar in the compact state.</summary>
    /// <returns>The negative vertical delta of the AppBar in the compact state.</returns>
    public extern double NegativeCompactVerticalDelta { [MethodImpl] get; }

    /// <summary>Gets the negative vertical delta of the AppBar in the minimal state.</summary>
    /// <returns>The negative vertical delta of the AppBar in the minimal state.</returns>
    public extern double NegativeMinimalVerticalDelta { [MethodImpl] get; }

    /// <summary>Gets the negative vertical delta of the AppBar in the hidden state.</summary>
    /// <returns>The negative vertical delta of the AppBar in the hidden state.</returns>
    public extern double NegativeHiddenVerticalDelta { [MethodImpl] get; }
  }
}
