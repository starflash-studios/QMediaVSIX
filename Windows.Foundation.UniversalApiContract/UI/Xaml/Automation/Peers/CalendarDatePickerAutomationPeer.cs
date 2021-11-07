// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.CalendarDatePickerAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes CalendarDatePicker types to Microsoft UI Automation.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (ICalendarDatePickerAutomationPeerFactory), CompositionType.Public, 393216, "Windows.Foundation.UniversalApiContract")]
  public class CalendarDatePickerAutomationPeer : 
    FrameworkElementAutomationPeer,
    ICalendarDatePickerAutomationPeer,
    IInvokeProvider,
    IValueProvider
  {
    /// <summary>Initializes a new instance of the CalendarDatePickerAutomationPeer class.</summary>
    /// <param name="owner">The owner element to create for.</param>
    [MethodImpl]
    public extern CalendarDatePickerAutomationPeer(CalendarDatePicker owner);

    /// <summary>Sends a request to open the CalendarDatePicker associated with the automation peer.</summary>
    [MethodImpl]
    public extern void Invoke();

    /// <summary>Gets a value that specifies whether the value of a control is read-only.</summary>
    /// <returns>**true** if the control value can be set; otherwise, **false**.</returns>
    public extern bool IsReadOnly { [MethodImpl] get; }

    /// <summary>Gets the value of the control.</summary>
    /// <returns>The value of the control, as a string.</returns>
    public extern string Value { [MethodImpl] get; }

    /// <summary>Sets the value of a control, as an implementation of the IValueProvider pattern.</summary>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public extern void SetValue(string value);
  }
}
