// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the method that will handle the CalendarViewDayItemChanging event.</summary>
  /// <param name="sender">The object where the event handler is attached.</param>
  /// <param name="e">The event data.</param>
  [WebHostHidden]
  [Guid(2373212305, 19939, 18891, 151, 75, 8, 56, 113, 163, 175, 230)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void CalendarViewDayItemChangingEventHandler(
    CalendarView sender,
    CalendarViewDayItemChangingEventArgs e);
}
