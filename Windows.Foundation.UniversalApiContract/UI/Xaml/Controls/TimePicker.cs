// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TimePicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that allows a user to pick a time value.</summary>
  [Static(typeof (ITimePickerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITimePickerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ContentProperty(Name = "Header")]
  [Composable(typeof (ITimePickerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITimePickerStatics3), 458752, "Windows.Foundation.UniversalApiContract")]
  public class TimePicker : Control, ITimePicker, ITimePicker2, ITimePicker3
  {
    /// <summary>Initializes a new instance of the TimePicker class.</summary>
    [MethodImpl]
    public extern TimePicker();

    /// <summary>Gets or sets the content for the control's header.</summary>
    /// <returns>The content of the control's header. The default is **null**.</returns>
    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display the content of the control's header.</summary>
    /// <returns>The template that specifies the visualization of the header object. The default is **null**.</returns>
    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the clock system to use.</summary>
    /// <returns>The name of the clock system to use. See Remarks.</returns>
    public extern string ClockIdentifier { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the time increments shown in the minute picker. For example, 15 specifies that the TimePicker minute control displays only the choices 00, 15, 30, 45.</summary>
    /// <returns>An integer from 0-59 that indicates the increments shown in the minute picker. The default is 1.</returns>
    public extern int MinuteIncrement { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time currently set in the time picker.</summary>
    /// <returns>The time currently set in the time picker.</returns>
    public extern TimeSpan Time { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the time value is changed.</summary>
    public extern event EventHandler<TimePickerValueChangedEventArgs> TimeChanged;

    /// <summary>Gets or sets a value that specifies whether the area outside of a *light-dismiss* UI is darkened.</summary>
    /// <returns>A value of the enumeration that specifies whether the area outside of a light-dismiss UI is darkened. The default is **Auto**.</returns>
    public extern LightDismissOverlayMode LightDismissOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time currently selected in the time picker.</summary>
    /// <returns>The time currently selected in the time picker.</returns>
    public extern IReference<TimeSpan> SelectedTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the selected time value is changed.</summary>
    public extern event TypedEventHandler<TimePicker, TimePickerSelectedValueChangedEventArgs> SelectedTimeChanged;

    /// <summary>Identifies the SelectedTime dependency property.</summary>
    /// <returns>The identifier for the SelectedTime dependency property.</returns>
    public static extern DependencyProperty SelectedTimeProperty { [MethodImpl] get; }

    /// <summary>Identifies the LightDismissOverlayMode dependency property.</summary>
    /// <returns>The identifier for the LightDismissOverlayMode dependency property.</returns>
    public static extern DependencyProperty LightDismissOverlayModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Header dependency property.</summary>
    /// <returns>The identifier for the Header dependency property.</returns>
    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the HeaderTemplate dependency property.</summary>
    /// <returns>The identifier for the HeaderTemplate dependency property.</returns>
    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the ClockIdentifier dependency property.</summary>
    /// <returns>The identifier for the ClockIdentifier dependency property.</returns>
    public static extern DependencyProperty ClockIdentifierProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the MinuteIncrement dependency property.</summary>
    /// <returns>The identifier for the MinuteIncrement dependency property.</returns>
    public static extern DependencyProperty MinuteIncrementProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Time dependency property.</summary>
    /// <returns>The identifier for the Time dependency property.</returns>
    public static extern DependencyProperty TimeProperty { [MethodImpl] get; }
  }
}
