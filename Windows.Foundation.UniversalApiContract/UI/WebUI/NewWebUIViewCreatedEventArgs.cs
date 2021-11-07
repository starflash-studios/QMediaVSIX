// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.NewWebUIViewCreatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  /// <summary>Provides info when a new WebUIView is created.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class NewWebUIViewCreatedEventArgs : INewWebUIViewCreatedEventArgs
  {
    /// <summary>Gets the web UI view that triggered the event.</summary>
    /// <returns>The view that triggered the event.</returns>
    public extern WebUIView WebUIView { [MethodImpl] get; }

    /// <summary>Gets info about the activated event that caused the view to be created.</summary>
    /// <returns>An object that provides info about the app's activation.</returns>
    public extern IActivatedEventArgs ActivatedEventArgs { [MethodImpl] get; }

    /// <summary>
    /// </summary>
    /// <returns>
    /// </returns>
    public extern bool HasPendingNavigate { [MethodImpl] get; }

    /// <summary>
    /// </summary>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
