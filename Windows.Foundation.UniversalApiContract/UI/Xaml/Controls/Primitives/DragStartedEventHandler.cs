// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.DragStartedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents the method that will handle the DragStarted event of a Thumb.</summary>
  /// <param name="sender">The object where the event handler is attached.</param>
  /// <param name="e">The event data.</param>
  [Guid(3538855050, 50778, 18781, 162, 241, 114, 198, 105, 137, 20, 45)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public delegate void DragStartedEventHandler(object sender, DragStartedEventArgs e);
}
