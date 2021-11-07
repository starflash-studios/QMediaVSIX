// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.FileRemovedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  /// <summary>Provides information about a fileremoved event.</summary>
  /// <deprecated type="deprecate">Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class FileRemovedEventArgs : IFileRemovedEventArgs
  {
    /// <summary>Gets the identifier of the file that the user removed from the list of chosen files in the file picker. This identifier was set by the providing app when it added the files to the list of chosen files.</summary>
    /// <returns>The identifier of the file.</returns>
    public extern string Id { [Deprecated("Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
