// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.CachedFileTarget
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  /// <summary>Indicates whether updates should be applied to the locally cached copy or the remote version of the file.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CachedFileTarget
  {
    /// <summary>Update the locally cached copy of the file.</summary>
    Local,
    /// <summary>Update the remote version of the file.</summary>
    Remote,
  }
}
