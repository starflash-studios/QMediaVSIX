// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ICalendarViewTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(1455887491, 25825, 18300, 138, 11, 203, 47, 51, 52, 185, 176)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CalendarViewTemplateSettings))]
  internal interface ICalendarViewTemplateSettings
  {
    double MinViewWidth { get; }

    string HeaderText { get; }

    string WeekDay1 { get; }

    string WeekDay2 { get; }

    string WeekDay3 { get; }

    string WeekDay4 { get; }

    string WeekDay5 { get; }

    string WeekDay6 { get; }

    string WeekDay7 { get; }

    bool HasMoreContentAfter { get; }

    bool HasMoreContentBefore { get; }

    bool HasMoreViews { get; }

    Rect ClipRect { get; }

    double CenterX { get; }

    double CenterY { get; }
  }
}
