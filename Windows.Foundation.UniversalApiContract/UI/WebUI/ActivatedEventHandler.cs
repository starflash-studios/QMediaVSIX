// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.ActivatedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  /// <summary>Represents a method that handles the app activation event.</summary>
  /// <param name="sender">The sender.</param>
  /// <param name="eventArgs">The event information. The data type depends on why the app was activated. For a list of possible data types, see the ActivationKind enumeration.</param>
  [Guid(1358030640, 50641, 19307, 154, 219, 138, 17, 117, 107, 226, 156)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void ActivatedEventHandler(object sender, IActivatedEventArgs eventArgs);
}
