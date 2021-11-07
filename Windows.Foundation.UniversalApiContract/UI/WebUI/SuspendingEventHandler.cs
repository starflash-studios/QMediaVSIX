// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.SuspendingEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  /// <summary>Represents a method that handles the app suspension event.</summary>
  /// <param name="sender">The sender.</param>
  /// <param name="e">The event data.</param>
  [Guid(1352417948, 30946, 18563, 171, 200, 137, 96, 220, 222, 27, 92)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void SuspendingEventHandler(object sender, ISuspendingEventArgs e);
}
