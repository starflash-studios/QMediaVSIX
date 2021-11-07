// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.BackgroundActivatedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  /// <summary>Provides info when a background task activates the app.</summary>
  /// <param name="sender">The object that triggered the event.</param>
  /// <param name="eventArgs">Information about the event.</param>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(3987840955, 1889, 18380, 154, 119, 36, 215, 7, 41, 101, 202)]
  public delegate void BackgroundActivatedEventHandler(
    object sender,
    IBackgroundActivatedEventArgs eventArgs);
}
