// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyLicenseManagement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Performs license management operations.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPlayReadyLicenseManagement), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class PlayReadyLicenseManagement
  {
    /// <summary>Deletes licenses that match the specified content header.</summary>
    /// <param name="contentHeader">Content header with a key identifier with which to match licenses.</param>
    /// <returns>The asynchronous operation performing the deletion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction DeleteLicenses(
      PlayReadyContentHeader contentHeader);
  }
}
