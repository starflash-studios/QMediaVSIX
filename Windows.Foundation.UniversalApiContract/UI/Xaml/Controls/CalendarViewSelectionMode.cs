// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CalendarViewSelectionMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify what kind of date selections are allowed in the calendar.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CalendarViewSelectionMode
  {
    /// <summary>Date selection is disabled.</summary>
    None,
    /// <summary>One date can be selected at a time.</summary>
    Single,
    /// <summary>One or more dates can be selected at a time.</summary>
    Multiple,
  }
}
