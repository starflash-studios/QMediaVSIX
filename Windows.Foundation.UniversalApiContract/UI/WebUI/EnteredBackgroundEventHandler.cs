// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.EnteredBackgroundEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  /// <summary>Represents a method that handles the entered background event.</summary>
  /// <param name="sender">The object that fired the event.</param>
  /// <param name="e">Information about the event.</param>
  [Guid(722051443, 46734, 19951, 136, 193, 141, 232, 78, 90, 171, 47)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public delegate void EnteredBackgroundEventHandler(object sender, IEnteredBackgroundEventArgs e);
}
