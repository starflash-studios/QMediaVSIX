// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BackgroundExecutionManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Manage permission to run background tasks.</summary>
  [Static(typeof (IBackgroundExecutionManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBackgroundExecutionManagerStatics3), 851968, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBackgroundExecutionManagerStatics2), 393216, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class BackgroundExecutionManager
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> RequestAccessKindForModernStandbyAsync(
      BackgroundAccessRequestKind requestedAccess,
      string reason);

    [Overload("GetAccessStatusForModernStandby")]
    [MethodImpl]
    public static extern BackgroundAccessStatus GetAccessStatusForModernStandby();

    [Overload("GetAccessStatusForModernStandbyForApplication")]
    [MethodImpl]
    public static extern BackgroundAccessStatus GetAccessStatusForModernStandby(
      string applicationId);

    /// <summary>Prompts the user whether they consent to allow the app to perform the specified level of background activity in the background. On the Desktop OS Edition this may present a prompt to the user for their consent.</summary>
    /// <param name="requestedAccess">The type of background activity the app wishes to perform.</param>
    /// <param name="reason">The string to display in the prompt that the system will raise to the user to describe why the app is requesting to run in the background. For example, the string that appears after "The app says:"</param>
    /// <returns>**True** indicates that the user or the system approved the requested background activity; **false**, otherwise.</returns>
    [RemoteAsync]
    [Overload("RequestAccessKindAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> RequestAccessKindAsync(
      BackgroundAccessRequestKind requestedAccess,
      string reason);

    /// <summary>Requests that the app be permitted to run background tasks.</summary>
    /// <returns>When the operation completes, it returns a member of the BackgroundAccessStatus enumeration that specifies the outcome.</returns>
    [Overload("RequestAccessAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BackgroundAccessStatus> RequestAccessAsync();

    /// <summary>Asynchronously requests that the app be permitted to run background tasks.</summary>
    /// <param name="applicationId">The package-relative application identifier (PRAID) of the app to be permitted to run background tasks. The specified app must be in the same package as the calling app. For more info on the PRAID, see the **Id** attribute of the Application element.</param>
    /// <returns>An asynchronous request operation. On successful completion, contains a member of the BackgroundAccessStatus enumeration that specifies the outcome.</returns>
    [Overload("RequestAccessForApplicationAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BackgroundAccessStatus> RequestAccessAsync(
      string applicationId);

    /// <summary>Removes the calling app from the list of apps that may run background tasks.</summary>
    [Overload("RemoveAccess")]
    [MethodImpl]
    public static extern void RemoveAccess();

    /// <summary>Removes a specific app from the list of apps that may run background tasks.</summary>
    /// <param name="applicationId">The package-relative application identifier (PRAID) of the app to be removed from the list of apps that may run background tasks. The specified app must be in the same package as the calling app. For more info on the PRAID, see the **Id** attribute of the Application element.</param>
    [Overload("RemoveAccessForApplication")]
    [MethodImpl]
    public static extern void RemoveAccess(string applicationId);

    /// <summary>Gets the app's background task execution capability.</summary>
    /// <returns>An enumeration value that specifies the app's background capabilities.</returns>
    [Overload("GetAccessStatus")]
    [MethodImpl]
    public static extern BackgroundAccessStatus GetAccessStatus();

    /// <summary>Gets the specified app's background task execution capability.</summary>
    /// <param name="applicationId">The package-relative application identifier (PRAID) of the app whose capabilities are being retrieved. The specified app must be in the same package as the calling app. For more info on the PRAID, see the **Id** attribute of the Application element.</param>
    /// <returns>An enumeration value that specifies the app's background capabilities.</returns>
    [Overload("GetAccessStatusForApplication")]
    [MethodImpl]
    public static extern BackgroundAccessStatus GetAccessStatus(
      string applicationId);
  }
}
