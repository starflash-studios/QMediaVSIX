// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TimePickedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the TimePicked event.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class TimePickedEventArgs : DependencyObject, ITimePickedEventArgs
  {
    /// <summary>Initializes a new instance of the TimePickedEventArgs class.</summary>
    [MethodImpl]
    public extern TimePickedEventArgs();

    /// <summary>Gets the old time value.</summary>
    /// <returns>The old time value.</returns>
    public extern TimeSpan OldTime { [MethodImpl] get; }

    /// <summary>Gets the time that was selected by the user.</summary>
    /// <returns>The time that was selected by the user.</returns>
    public extern TimeSpan NewTime { [MethodImpl] get; }
  }
}
