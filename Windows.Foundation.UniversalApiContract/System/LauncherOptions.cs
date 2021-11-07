// Decompiled with JetBrains decompiler
// Type: Windows.System.LauncherOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Search;
using Windows.UI.ViewManagement;

namespace Windows.System
{
  /// <summary>Specifies the options used to launch the default app for a file or URI.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LauncherOptions : 
    ILauncherOptions2,
    ILauncherOptions,
    ILauncherOptions3,
    ILauncherOptions4,
    ILauncherViewOptions
  {
    /// <summary>Creates and initializes a new instance of the launcher options object.</summary>
    [MethodImpl]
    public extern LauncherOptions();

    /// <summary>The package family name of the target package that should be used to launch a file or URI. This property is optional.</summary>
    /// <returns>The package family name of the target package that should be used to launch a file or URI. This property is optional.</returns>
    public extern string TargetApplicationPackageFamilyName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Enables an app to access files that are related to the file used to activate the app.</summary>
    /// <returns>A query containing the list of related files.</returns>
    public extern StorageFileQueryResult NeighboringFilesQuery { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the system should display a warning that the file or URI is potentially unsafe when starting the app associated with a file or URI.</summary>
    /// <returns>True if the warning should be displayed; otherwise false.</returns>
    public extern bool TreatAsUntrusted { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether to display the **Open With** dialog whenever the association launching API is called.</summary>
    /// <returns>True if the **Open With** dialog should always be displayed; otherwise false.</returns>
    public extern bool DisplayApplicationPicker { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the user interface (UI) options when starting a default app.</summary>
    /// <returns>The UI options.</returns>
    public extern LauncherUIOptions UI { [MethodImpl] get; }

    /// <summary>Gets or sets a value that represents the package family name of the app in the Store that the user should install if no app exists to handle the file type or URI.</summary>
    /// <returns>The package family name of the app.</returns>
    public extern string PreferredApplicationPackageFamilyName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that represents the display name of the app in the store that the user should install if no app exists to handle the file type or URI.</summary>
    /// <returns>The display name of the app.</returns>
    public extern string PreferredApplicationDisplayName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that represents a URI that the user should be taken to in the browser if no app exists to handle the file type or URI.</summary>
    /// <returns>URI that the user should be taken to in the browser.</returns>
    public extern Uri FallbackUri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the content type that is associated with a URI that represents a file on the network.</summary>
    /// <returns>The content type of the URI.</returns>
    public extern string ContentType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates whether to ignore handlers that can handle http(s) schemes (such as browsers). Instead, launch will fall back to the default browser.</summary>
    /// <returns>**True** indicates that apps that can handle http(s) schemes will be ignored and instead the URI will be opened in the default browser; **false** otherwise.</returns>
    public extern bool IgnoreAppUriHandlers { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether to limit the picker for the launcher to the current app and its associated URI handlers.</summary>
    /// <returns>True if the launcher should limit the picker to the current app and its associated URI handlers; otherwise, false.</returns>
    public extern bool LimitPickerToCurrentAppAndAppUriHandlers { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Launch a target app and have the currently running source app remain on the screen by sharing the space equally with the target app or by taking up more or less space than the target app.</summary>
    /// <returns>A ViewSizePreference -typed value that specifies the app’s desired view size.</returns>
    public extern ViewSizePreference DesiredRemainingView { [MethodImpl] get; [MethodImpl] set; }
  }
}
