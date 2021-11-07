// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.INetworkOperatorTetheringOperationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (NetworkOperatorTetheringOperationResult))]
  [Guid(3956409249, 442, 18285, 180, 179, 191, 61, 18, 200, 248, 12)]
  internal interface INetworkOperatorTetheringOperationResult
  {
    TetheringOperationStatus Status { get; }

    string AdditionalErrorMessage { get; }
  }
}
