// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDStorageFileHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Manages PlayReady-ND storage files.</summary>
  /// <deprecated type="deprecate">INDStorageFileHelper is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Guid(3639656184, 37330, 19783, 163, 249, 234, 255, 78, 219, 114, 159)]
  [Deprecated("INDStorageFileHelper is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INDStorageFileHelper
  {
    /// <summary>Gets transmitter settings from the URLs associated with a  object if the URLs contain PlayReady-ND metadata.</summary>
    /// <deprecated type="deprecate">INDStorageFileHelper is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="file">A storage file object that a media server has discovered.</param>
    /// <returns>The transmitter settings found in the storage file.</returns>
    [Deprecated("INDStorageFileHelper is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    IVector<string> GetFileURLs(IStorageFile file);
  }
}
