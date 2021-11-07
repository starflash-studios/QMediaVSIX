// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUINavigatedDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  /// <summary>Manages delayed navigation for an app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class WebUINavigatedDeferral : IWebUINavigatedDeferral
  {
    /// <summary>Notifies the system that the app has set up its state and UI and is ready to be displayed after a top level navigation.</summary>
    [MethodImpl]
    public extern void Complete();
  }
}
