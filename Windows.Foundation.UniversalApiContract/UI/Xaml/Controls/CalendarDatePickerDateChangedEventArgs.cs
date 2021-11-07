// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CalendarDatePickerDateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the DateChanged event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CalendarDatePickerDateChangedEventArgs : 
    ICalendarDatePickerDateChangedEventArgs
  {
    /// <summary>Gets the date that is currently selected in the CalendarDatePicker.</summary>
    /// <returns>The date that is currently selected in the CalendarDatePicker.</returns>
    public extern IReference<DateTime> NewDate { [MethodImpl] get; }

    /// <summary>Gets the date that was previously selected in the CalendarDatePicker.</summary>
    /// <returns>The date that was previously selected in the CalendarDatePicker.</returns>
    public extern IReference<DateTime> OldDate { [MethodImpl] get; }
  }
}
