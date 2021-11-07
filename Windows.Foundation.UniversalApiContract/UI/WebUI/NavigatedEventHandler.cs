// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.NavigatedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  /// <summary>Represents a method that handles the app navigation event.</summary>
  /// <param name="sender">The sender.</param>
  /// <param name="e">The event information.</param>
  [Guid(2062839782, 16586, 20041, 167, 214, 219, 219, 51, 12, 209, 163)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void NavigatedEventHandler(object sender, IWebUINavigatedEventArgs e);
}
