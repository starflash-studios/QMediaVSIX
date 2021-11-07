// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.UIStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  /// <summary>Indicates the status of the file picker UI.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UIStatus
  {
    /// <summary>The file picker is not showing UI and UI can't be requested.</summary>
    Unavailable,
    /// <summary>The file picker is not showing UI, but UI can be requested.</summary>
    Hidden,
    /// <summary>The file picker is currently showing UI because UI was requested by the app.</summary>
    Visible,
    /// <summary>The file picker is currently showing UI and all</summary>
    Complete,
  }
}
