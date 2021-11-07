// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Printing.GetPreviewPageEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Printing
{
  /// <summary>Represents the method that will handle the GetPreviewPage event.</summary>
  /// <param name="sender">The object where the handler is attached.</param>
  /// <param name="e">Event data for the event.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3434342893, 39953, 20048, 171, 73, 233, 128, 134, 187, 253, 239)]
  [WebHostHidden]
  public delegate void GetPreviewPageEventHandler(object sender, GetPreviewPageEventArgs e);
}
