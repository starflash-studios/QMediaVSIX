// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.AppWindowPresenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  /// <summary>Displays an app window using a pre-defined configuration appropriate for the device it's shown on.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class AppWindowPresenter : IAppWindowPresenter
  {
    /// <summary>Gets the configuration info for the app window presenter.</summary>
    /// <returns>The configuration info for the app window presenter.</returns>
    [MethodImpl]
    public extern AppWindowPresentationConfiguration GetConfiguration();

    /// <summary>Gets a value that indicates whether the kind of presentation is supported.</summary>
    /// <param name="presentationKind">The kind of presentation.</param>
    /// <returns>**true** if the AppWindowPresentationKind is supported; otherwise; **false**.</returns>
    [MethodImpl]
    public extern bool IsPresentationSupported(AppWindowPresentationKind presentationKind);

    /// <summary>Makes a request to show the window using the specified presentation configuration.</summary>
    /// <param name="configuration">The presentation configuration to use to show the app window.</param>
    /// <returns>**true** if the request succeeds; otherwise, **false**.</returns>
    [Overload("RequestPresentation")]
    [MethodImpl]
    public extern bool RequestPresentation(AppWindowPresentationConfiguration configuration);

    /// <summary>Makes a request to show the window using the specified kind of presentation.</summary>
    /// <param name="presentationKind">The kind of presentation to use to show the app window.</param>
    /// <returns>**true** if the request succeeds; otherwise, **false**.</returns>
    [DefaultOverload]
    [Overload("RequestPresentationByKind")]
    [MethodImpl]
    public extern bool RequestPresentation(AppWindowPresentationKind presentationKind);
  }
}
