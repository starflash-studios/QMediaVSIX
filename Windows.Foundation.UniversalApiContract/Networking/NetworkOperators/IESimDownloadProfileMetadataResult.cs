// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IESimDownloadProfileMetadataResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (ESimDownloadProfileMetadataResult))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(3290647966, 23254, 17005, 141, 0, 68, 52, 244, 73, 175, 236)]
  internal interface IESimDownloadProfileMetadataResult
  {
    ESimOperationResult Result { get; }

    ESimProfileMetadata ProfileMetadata { get; }
  }
}
