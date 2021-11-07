// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IESimOperationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(2793104305, 12443, 20087, 158, 126, 205, 147, 241, 221, 199, 185)]
  [ExclusiveTo(typeof (ESimOperationResult))]
  internal interface IESimOperationResult
  {
    ESimOperationStatus Status { get; }
  }
}
