// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ScrollEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents the method that will handle the Scroll event of a ScrollBar.</summary>
  /// <param name="sender">The source of the event.</param>
  /// <param name="e">A ScrollEventArgs that contains the event data.</param>
  [Guid(2288038052, 41859, 19587, 179, 6, 161, 195, 157, 125, 184, 127)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void ScrollEventHandler(object sender, ScrollEventArgs e);
}
