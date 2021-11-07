// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.CachedFileUpdaterUI
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  /// <summary>Used to interact with the file picker if your app provides file updates through the Cached File Updater contract.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CachedFileUpdaterUI : ICachedFileUpdaterUI, ICachedFileUpdaterUI2
  {
    /// <summary>Gets or sets the title to display in the top-left the file picker UI. The title identifies the location or context of the app's page (which is hosted in the file picker UI) for the user.</summary>
    /// <returns>The title to display in the top-left of the file picker UI.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates which version of the file needs to be updated: the local version or the version in the app's repository.</summary>
    /// <returns>An enum value that indicates which version of the file needs to be updated: the local version or the version in the app's repository.</returns>
    public extern CachedFileTarget UpdateTarget { [MethodImpl] get; }

    /// <summary>Fires when the Windows requests a file update. This event fires once for each requested update.</summary>
    public extern event TypedEventHandler<CachedFileUpdaterUI, FileUpdateRequestedEventArgs> FileUpdateRequested;

    /// <summary>Fires when the calling app needs to display the file picker letterbox UI that is represented by the CachedFileUpdaterUI object.</summary>
    public extern event TypedEventHandler<CachedFileUpdaterUI, object> UIRequested;

    /// <summary>Gets an enum value that indicates the status of the file picker UI.</summary>
    /// <returns>The UIStatus value that indicates the status of the file picker UI.</returns>
    public extern UIStatus UIStatus { [MethodImpl] get; }

    /// <summary>Gets the file update request currently being processed by the cached file updater.</summary>
    /// <returns>The file update request currently being processed by the cached file updater.</returns>
    public extern FileUpdateRequest UpdateRequest { [MethodImpl] get; }

    /// <summary>Gets an object used to complete a file update request asynchronously.</summary>
    /// <returns>The object that the app uses to indicate, asynchronously, that it has finished responding to a FileUpdateRequested event and that the Request is complete.</returns>
    [MethodImpl]
    public extern FileUpdateRequestDeferral GetDeferral();
  }
}
