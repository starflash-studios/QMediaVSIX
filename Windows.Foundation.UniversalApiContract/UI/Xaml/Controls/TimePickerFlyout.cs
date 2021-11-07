// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TimePickerFlyout
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that allows a user to pick a time value.</summary>
  [Static(typeof (ITimePickerFlyoutStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class TimePickerFlyout : PickerFlyoutBase, ITimePickerFlyout
  {
    /// <summary>Initializes a new instance of the TimePickerFlyout class.</summary>
    [MethodImpl]
    public extern TimePickerFlyout();

    /// <summary>Gets or sets the clock system to use.</summary>
    /// <returns>The name of the clock system to use.</returns>
    public extern string ClockIdentifier { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time currently set in the time picker.</summary>
    /// <returns>The time currently set in the time picker.</returns>
    public extern TimeSpan Time { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the time increments shown in the minute picker. For example, 15 specifies that minute picker displays only the choices 00, 15, 30, 45.</summary>
    /// <returns>An integer from 0-59 that indicates the increments shown in the minute picker. The default is 1.</returns>
    public extern int MinuteIncrement { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the user has selected a time in the time picker flyout.</summary>
    public extern event TypedEventHandler<TimePickerFlyout, TimePickedEventArgs> TimePicked;

    /// <summary>Begins an asynchronous operation to show the flyout placed in relation to the specified element.</summary>
    /// <param name="target">The element to use as the flyout's placement target.</param>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IReference<TimeSpan>> ShowAtAsync(
      FrameworkElement target);

    /// <summary>Gets the identifier for the ClockIdentifier dependency property.</summary>
    /// <returns>The identifier for the ClockIdentifier dependency property.</returns>
    public static extern DependencyProperty ClockIdentifierProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Time dependency property.</summary>
    /// <returns>The identifier for the Time dependency property.</returns>
    public static extern DependencyProperty TimeProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the MinuteIncrement dependency property.</summary>
    /// <returns>The identifier for the MinuteIncrement dependency property.</returns>
    public static extern DependencyProperty MinuteIncrementProperty { [MethodImpl] get; }
  }
}
