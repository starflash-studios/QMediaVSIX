// Decompiled with JetBrains decompiler
// Type: Windows.System.FolderLauncherOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.UI.ViewManagement;

namespace Windows.System
{
  /// <summary>Specifies the options to use when launching File Explorer to display the contents of a specific folder by calling the LaunchFolderAsync(IStorageFolder, FolderLauncherOptions) method.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class FolderLauncherOptions : IFolderLauncherOptions, ILauncherViewOptions
  {
    /// <summary>Initializes a new instance of the FolderLauncherOptions class.</summary>
    [MethodImpl]
    public extern FolderLauncherOptions();

    /// <summary>Provides the list of items to select when File Explorer displays the contents of the specified folder.</summary>
    /// <returns>The list of items to select when File Explorer displays the contents of the specified folder.</returns>
    public extern IVector<IStorageItem> ItemsToSelect { [MethodImpl] get; }

    /// <summary>Specifies how much space on the screen to leave for the calling app when launching File Explorer. The calling app can take up more or less space than File Explorer, or File Explorer can fill the entire screen.</summary>
    /// <returns>One of the enumeration values that specifies how much space on the screen to leave for the calling app when launching File Explorer.</returns>
    public extern ViewSizePreference DesiredRemainingView { [MethodImpl] get; [MethodImpl] set; }
  }
}
