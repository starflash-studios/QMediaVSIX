// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IESimDiscoverResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (ESimDiscoverResult))]
  [Guid(1454685022, 43823, 23238, 179, 89, 221, 90, 142, 35, 121, 38)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IESimDiscoverResult
  {
    IVectorView<ESimDiscoverEvent> Events { get; }

    ESimDiscoverResultKind Kind { get; }

    ESimProfileMetadata ProfileMetadata { get; }

    ESimOperationResult Result { get; }
  }
}
