// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.CalendarViewTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides calculated values that can be referenced as **TemplatedParent** sources when defining templates for a CalendarView control. Not intended for general use.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class CalendarViewTemplateSettings : DependencyObject, ICalendarViewTemplateSettings
  {
    /// <summary>Gets the minimum width of the view.</summary>
    /// <returns>The minimum width of the view.</returns>
    public extern double MinViewWidth { [MethodImpl] get; }

    /// <summary>Gets the text of the header.</summary>
    /// <returns>The text of the header.</returns>
    public extern string HeaderText { [MethodImpl] get; }

    /// <summary>Gets the first day of the week.</summary>
    /// <returns>The first day of the week.</returns>
    public extern string WeekDay1 { [MethodImpl] get; }

    /// <summary>Gets the second day of the week.</summary>
    /// <returns>The second day of the week.</returns>
    public extern string WeekDay2 { [MethodImpl] get; }

    /// <summary>Gets the third day of the week.</summary>
    /// <returns>The third day of the week.</returns>
    public extern string WeekDay3 { [MethodImpl] get; }

    /// <summary>Gets the fourth day of the week.</summary>
    /// <returns>The fourth day of the week.</returns>
    public extern string WeekDay4 { [MethodImpl] get; }

    /// <summary>Gets the fifth day of the week.</summary>
    /// <returns>The fifth day of the week.</returns>
    public extern string WeekDay5 { [MethodImpl] get; }

    /// <summary>Gets the sixth day of the week.</summary>
    /// <returns>The sixth day of the week.</returns>
    public extern string WeekDay6 { [MethodImpl] get; }

    /// <summary>Gets the seventh day of the week.</summary>
    /// <returns>The seventh day of the week.</returns>
    public extern string WeekDay7 { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the CalendarView has more content after the displayed content.</summary>
    /// <returns>**true** if the CalendarView has more content after the displayed content; otherwise, **false**.</returns>
    public extern bool HasMoreContentAfter { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the CalendarView has more content before the displayed content.</summary>
    /// <returns>**true** if the CalendarView has more content after the displayed content; otherwise, **false**.</returns>
    public extern bool HasMoreContentBefore { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the CalendarView has more views (like year or decade) that can be shown.</summary>
    /// <returns>**true** if the CalendarView has more views (like year or decade) that can be shown; otherwise, **false**.</returns>
    public extern bool HasMoreViews { [MethodImpl] get; }

    /// <summary>Gets the rectangle used to clip the CalendarView.</summary>
    /// <returns>The rectangle used to clip the CalendarView.</returns>
    public extern Rect ClipRect { [MethodImpl] get; }

    /// <summary>Gets the X coordinate of the CalendarView 's center point.</summary>
    /// <returns>The X coordinate of the CalendarView 's center point.</returns>
    public extern double CenterX { [MethodImpl] get; }

    /// <summary>Gets the Y coordinate of the CalendarView 's center point.</summary>
    /// <returns>The Y coordinate of the CalendarView 's center point.</returns>
    public extern double CenterY { [MethodImpl] get; }
  }
}
