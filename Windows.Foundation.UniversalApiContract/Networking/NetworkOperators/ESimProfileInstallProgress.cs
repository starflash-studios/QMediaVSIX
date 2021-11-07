// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimProfileInstallProgress
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents the result of an asynchronous (with progress) operation to download and install an eSIM profile.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public struct ESimProfileInstallProgress
  {
    /// <summary>The total size of the eSIM profile in whole bytes.</summary>
    public int TotalSizeInBytes;
    /// <summary>The installed size of the eSIM profile in whole bytes.</summary>
    public int InstalledSizeInBytes;
  }
}
