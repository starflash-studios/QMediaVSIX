// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundTransferOperationPriority
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Use this interface to determine the priority of a downloads or uploads within a BackgroundTransferGroup. Possible values are defined by the BackgroundTransferPriority enumeration.</summary>
  [Guid(75842343, 21076, 19258, 145, 94, 10, 164, 146, 117, 192, 249)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IBackgroundTransferOperationPriority
  {
    /// <summary>Gets or sets the priority of a download or upload operation. Possible values are defined by the BackgroundTransferPriority enumeration.</summary>
    /// <returns>The priority of the operation.</returns>
    BackgroundTransferPriority Priority { get; set; }
  }
}
