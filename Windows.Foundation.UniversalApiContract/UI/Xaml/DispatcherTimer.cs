// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DispatcherTimer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides a timer that is integrated into the **Dispatcher** queue, which is processed at a specified interval of time and at a specified priority.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IDispatcherTimerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class DispatcherTimer : IDispatcherTimer
  {
    /// <summary>Initializes a new instance of the DispatcherTimer class.</summary>
    [MethodImpl]
    public extern DispatcherTimer();

    /// <summary>Gets or sets the amount of time between timer ticks.</summary>
    /// <returns>The amount of time between ticks. The default is a **TimeSpan**</returns>
    public extern TimeSpan Interval { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the timer is running.</summary>
    /// <returns>**true** if the timer is enabled and running; otherwise, **false**.</returns>
    public extern bool IsEnabled { [MethodImpl] get; }

    /// <summary>Occurs when the timer interval has elapsed.</summary>
    public extern event EventHandler<object> Tick;

    /// <summary>Starts the DispatcherTimer.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops the DispatcherTimer.</summary>
    [MethodImpl]
    public extern void Stop();
  }
}
