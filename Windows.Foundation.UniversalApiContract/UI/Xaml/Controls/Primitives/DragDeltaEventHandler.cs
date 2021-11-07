// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.DragDeltaEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents the method that will handle the DragDelta event of a Thumb.</summary>
  /// <param name="sender">The object where the event handler is attached.</param>
  /// <param name="e">The event data.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1254248351, 44072, 18921, 145, 137, 220, 207, 254, 182, 100, 114)]
  public delegate void DragDeltaEventHandler(object sender, DragDeltaEventArgs e);
}
