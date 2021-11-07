// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.CashDrawerCloseAlarm
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>The cash drawer close alarm. Parameter defaults are provided, however the user can update them as appropriate.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class CashDrawerCloseAlarm : ICashDrawerCloseAlarm
  {
    /// <summary>Gets or sets the alarm timeout for the cash drawer close alarm.</summary>
    /// <returns>Defines the amount of time for the alarm timeout.</returns>
    public extern TimeSpan AlarmTimeout { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Frequency of beep tone.</summary>
    /// <returns>Defines the audio frequency of the beep tone.</returns>
    public extern uint BeepFrequency { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Duration of the cash drawer close alarm beep.</summary>
    /// <returns>Defines the length of time the alarm beep sounds.</returns>
    public extern TimeSpan BeepDuration { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Delay between cash drawer closed alarm beeps.</summary>
    /// <returns>Defines the amount of time between beeps.</returns>
    public extern TimeSpan BeepDelay { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Event allowing the app to be notified if the alarm timeout has been triggered.</summary>
    public extern event TypedEventHandler<CashDrawerCloseAlarm, object> AlarmTimeoutExpired;

    /// <summary>Starts the alarm countdown, returning an awaitable object that completes when the cash drawer is closed.</summary>
    /// <returns>True if the drawer has been closed; otherwise, false indicates a problem has occurred.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> StartAsync();
  }
}
