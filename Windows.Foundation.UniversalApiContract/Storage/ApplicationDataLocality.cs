// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ApplicationDataLocality
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Specifies the type of an application data store.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ApplicationDataLocality
  {
    /// <summary>The data resides in the local application data store.</summary>
    Local,
    /// <summary>The data resides in the roaming application data store.</summary>
    Roaming,
    /// <summary>The data resides in the temporary application data store.</summary>
    Temporary,
    /// <summary>The data resides in the local cache for the application data store.</summary>
    LocalCache,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 786432)] SharedLocal,
  }
}
