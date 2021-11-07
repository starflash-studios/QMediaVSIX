// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.RangeBaseAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>A base class that provides a Microsoft UI Automation peer implementation for types that derive from RangeBase.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IRangeBaseAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class RangeBaseAutomationPeer : 
    FrameworkElementAutomationPeer,
    IRangeBaseAutomationPeer,
    IRangeValueProvider
  {
    /// <summary>Initializes a new instance of the RangeBaseAutomationPeer class.</summary>
    /// <param name="owner">The owner element to create for.</param>
    [MethodImpl]
    public extern RangeBaseAutomationPeer(RangeBase owner);

    /// <summary>Gets a value that indicates whether the value of a control is read-only.</summary>
    /// <returns>**true** if the value is read-only; **false** if it can be modified.</returns>
    public extern bool IsReadOnly { [MethodImpl] get; }

    /// <summary>Gets the value that is added to or subtracted from the Value property when a large change is made, such as with the PAGE DOWN key.</summary>
    /// <returns>The large-change value supported by the control.</returns>
    public extern double LargeChange { [MethodImpl] get; }

    /// <summary>Gets the maximum range value that is supported by the control.</summary>
    /// <returns>The maximum range value supported by the control.</returns>
    public extern double Maximum { [MethodImpl] get; }

    /// <summary>Gets the minimum range value that is supported by the control.</summary>
    /// <returns>The minimum range value supported by the control.</returns>
    public extern double Minimum { [MethodImpl] get; }

    /// <summary>Gets the value that is added to or subtracted from the Value property when a small change is made, such as with an arrow key.</summary>
    /// <returns>The small-change value supported by the control.</returns>
    public extern double SmallChange { [MethodImpl] get; }

    /// <summary>Gets the value of the control.</summary>
    /// <returns>The value of the control.</returns>
    public extern double Value { [MethodImpl] get; }

    /// <summary>Sets the value of the control, as an implementation of the IValueProvider pattern.</summary>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public extern void SetValue(double value);
  }
}
