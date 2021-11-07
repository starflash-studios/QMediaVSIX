// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.WriteActivationMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  /// <summary>Indicates whether other apps can write to the locally cached version of the file and when Windows will request an update if another app writes to that local file.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WriteActivationMode
  {
    /// <summary>Other apps can't write to the local file.</summary>
    ReadOnly,
    /// <summary>Windows will trigger a file update request when another app writes to the local file.</summary>
    NotNeeded,
    /// <summary>Windows will trigger a file update request after another app writes to the local file.</summary>
    AfterWrite,
  }
}
