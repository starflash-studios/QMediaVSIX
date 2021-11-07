// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TextControlPasteEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the method that will handle a **Paste** event.</summary>
  /// <param name="sender">The object where the handler is attached.</param>
  /// <param name="e">Event data for the event.</param>
  [WebHostHidden]
  [Guid(3580736345, 28535, 17046, 171, 156, 121, 73, 57, 68, 67, 101)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void TextControlPasteEventHandler(object sender, TextControlPasteEventArgs e);
}
