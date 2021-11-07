// Decompiled with JetBrains decompiler
// Type: Windows.Services.Cortana.CortanaActionableInsights
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.System;

namespace Windows.Services.Cortana
{
  /// <summary>Derives contextual insights from images or text that let the user learn more about the content, or perform an action based on it.</summary>
  [Static(typeof (ICortanaActionableInsightsStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class CortanaActionableInsights : ICortanaActionableInsights
  {
    /// <summary>Gets the user associated with the current CortanaActionableInsights object.</summary>
    /// <returns>The User associated with the current CortanaActionableInsights object.</returns>
    public extern User User { [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Asynchronously retrieves whether insights can be generated on the user's current system.</summary>
    /// <returns>An IAsyncOperation object used to control asynchronous execution. The IAsyncOperation will contain **true** if insights can be generated. Otherwise, **false**.</returns>
    [RemoteAsync]
    [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<bool> IsAvailableAsync();

    /// <summary>Asynchronously retrieves and displays insights based on the specified image content.</summary>
    /// <param name="imageStream">The image that defines the scope of the insights returned.</param>
    /// <returns>Returns an IAsyncAction object that is used to control asynchronous execution. If the system does not support showing insights, the method has no effect. An app can check for this case using the IsAvailableAsync method.</returns>
    [Overload("ShowInsightsForImageAsync")]
    [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ShowInsightsForImageAsync(
      IRandomAccessStreamReference imageStream);

    /// <summary>Asynchronously retrieves and displays insights based on the specified image content and options.</summary>
    /// <param name="imageStream">The image that defines the scope of the insights returned.</param>
    /// <param name="options">The options that constrain the scope of the insights returned.</param>
    /// <returns>Returns an IAsyncAction object that is used to control asynchronous execution. If the system does not support showing insights, the method has no effect. An app can check for this case using the IsAvailableAsync method.</returns>
    [RemoteAsync]
    [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [Overload("ShowInsightsForImageWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncAction ShowInsightsForImageAsync(
      IRandomAccessStreamReference imageStream,
      CortanaActionableInsightsOptions options);

    /// <summary>Asynchronously retrieves and displays insights based on the specified text content.</summary>
    /// <param name="text">The text that defines the scope of the insights returned.</param>
    /// <returns>Returns an IAsyncAction object that is used to control asynchronous execution. If the system does not support showing insights, the method has no effect. An app can check for this case using the IsAvailableAsync method.</returns>
    [RemoteAsync]
    [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [Overload("ShowInsightsForTextAsync")]
    [MethodImpl]
    public extern IAsyncAction ShowInsightsForTextAsync(string text);

    /// <summary>Asynchronously retrieves and displays insights based on the specified text content and options.</summary>
    /// <param name="text">The text that defines the scope of the insights returned.</param>
    /// <param name="options">The options that constrain the scope of the insights returned.</param>
    /// <returns>Returns an IAsyncAction object used to control asynchronous execution. If the system does not support showing insights, the method has no effect. An app can check for this case using the IsAvailableAsync method.</returns>
    [Overload("ShowInsightsForTextWithOptionsAsync")]
    [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ShowInsightsForTextAsync(
      string text,
      CortanaActionableInsightsOptions options);

    /// <summary>Asynchronously retrieves and displays insights based on the specified text and image content.</summary>
    /// <param name="datapackage">The text and image content that defines the scope of the insights returned.</param>
    /// <returns>Returns an IAsyncAction object that is used to control asynchronous execution. If the system does not support showing insights, the method has no effect. An app can check for this case using the IsAvailableAsync method.</returns>
    [Overload("ShowInsightsAsync")]
    [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ShowInsightsAsync(DataPackage datapackage);

    /// <summary>Asynchronously retrieves and displays insights based on the specified text and image content and options.</summary>
    /// <param name="datapackage">The text and image content that defines the scope of the insights returned.</param>
    /// <param name="options">The options that constrain the scope of the insights returned, such as metadata derived from the surrounding context of the text and image content.</param>
    /// <returns>Returns an IAsyncAction object that is used to control asynchronous execution. If the system does not support showing insights, the method has no effect. An app can check for this case using the IsAvailableAsync method.</returns>
    [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [Overload("ShowInsightsWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncAction ShowInsightsAsync(
      DataPackage datapackage,
      CortanaActionableInsightsOptions options);

    /// <summary>Retrieves a CortanaActionableInsights object for the current user.</summary>
    /// <returns>The insights for the current user.</returns>
    [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern CortanaActionableInsights GetDefault();

    /// <summary>Retrieves a CortanaActionableInsights object for the specified user.</summary>
    /// <param name="user">The user.</param>
    /// <returns>The insights for the specified user.</returns>
    [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern CortanaActionableInsights GetForUser(User user);
  }
}
