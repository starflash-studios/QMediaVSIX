// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CalendarViewDisplayMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify which view of the calendar is shown.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum CalendarViewDisplayMode
  {
    /// <summary>The month view is shown.</summary>
    Month,
    /// <summary>The year selector view is shown.</summary>
    Year,
    /// <summary>The decade selector view is shown.</summary>
    Decade,
  }
}
