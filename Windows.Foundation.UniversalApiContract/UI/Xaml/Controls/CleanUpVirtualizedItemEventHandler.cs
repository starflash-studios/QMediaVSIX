// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CleanUpVirtualizedItemEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the method that handles the CleanUpVirtualizedItemEvent attached event.</summary>
  /// <param name="sender">The source of the event.</param>
  /// <param name="e">The event data.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3402289366, 3853, 18544, 136, 77, 242, 222, 223, 103, 66, 136)]
  public delegate void CleanUpVirtualizedItemEventHandler(
    object sender,
    CleanUpVirtualizedItemEventArgs e);
}
