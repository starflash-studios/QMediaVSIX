// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.WindowClosedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml
{
  /// <summary>Represents the method that will handle the Closed event.</summary>
  /// <param name="sender">The object where the handler is attached.</param>
  /// <param name="e">Event data for the event.</param>
  [Guid(230199649, 8407, 17887, 145, 34, 186, 137, 87, 103, 3, 186)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void WindowClosedEventHandler(object sender, CoreWindowEventArgs e);
}
