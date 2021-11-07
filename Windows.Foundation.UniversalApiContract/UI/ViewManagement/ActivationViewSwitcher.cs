// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ActivationViewSwitcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Provides methods for switching to an app view in response to an activation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ActivationViewSwitcher : IActivationViewSwitcher
  {
    /// <summary>Shows the view in a new standalone window.</summary>
    /// <param name="viewId">The identifier for the view.</param>
    /// <returns>The asynchronous results of the operation. Use this to determine when the async call is complete.</returns>
    [Overload("ShowAsStandaloneAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ShowAsStandaloneAsync(int viewId);

    /// <summary>Shows the view in a new standalone window and sets the size preference for the view.</summary>
    /// <param name="viewId">The identifier for the view.</param>
    /// <param name="sizePreference">The preferred size of the view.</param>
    /// <returns>The asynchronous results of the operation. Use this to determine when the async call is complete.</returns>
    [Overload("ShowAsStandaloneWithSizePreferenceAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ShowAsStandaloneAsync(
      int viewId,
      ViewSizePreference sizePreference);

    /// <summary>Returns a value that indicates whether the specified view is present on the virtual desktop that the activation was initiated on.</summary>
    /// <param name="viewId">The identifier for that view that is being activated.</param>
    /// <returns>**true** if the view is present on the virtual desktop that the activation was initiated on; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool IsViewPresentedOnActivationVirtualDesktop(int viewId);
  }
}
