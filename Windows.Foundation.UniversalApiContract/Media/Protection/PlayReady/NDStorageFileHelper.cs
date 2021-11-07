// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.NDStorageFileHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Manages PlayReady-ND storage files.</summary>
  /// <deprecated type="deprecate">NDStorageFileHelper is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Deprecated("NDStorageFileHelper is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class NDStorageFileHelper : INDStorageFileHelper
  {
    /// <summary>Creates a new instance of the NDStorageFileHelper class.</summary>
    [MethodImpl]
    public extern NDStorageFileHelper();

    /// <summary>Gets transmitter settings from the URLs associated with a **StorageFile** object if the URLs contain PlayReady-ND metadata.</summary>
    /// <deprecated type="deprecate">INDStorageFileHelper is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="file">A storage file object that a media server has discovered.</param>
    /// <returns>The transmitter settings found in the storage file.</returns>
    [Deprecated("INDStorageFileHelper is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IVector<string> GetFileURLs(IStorageFile file);
  }
}
