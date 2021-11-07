// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TimePickerSelectedValueChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the TimePicker.SelectedTimeChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TimePickerSelectedValueChangedEventArgs : 
    ITimePickerSelectedValueChangedEventArgs
  {
    /// <summary>Gets the time previously selected in the picker.</summary>
    /// <returns>The time previously selected in the picker.</returns>
    public extern IReference<TimeSpan> OldTime { [MethodImpl] get; }

    /// <summary>Gets the new time selected in the picker.</summary>
    /// <returns>The new time selected in the picker.</returns>
    public extern IReference<TimeSpan> NewTime { [MethodImpl] get; }
  }
}
