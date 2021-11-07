// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandUiccAppRecordDetailsResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(3642320943, 48660, 18740, 152, 29, 47, 87, 185, 237, 131, 230)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MobileBroadbandUiccAppRecordDetailsResult))]
  internal interface IMobileBroadbandUiccAppRecordDetailsResult
  {
    MobileBroadbandUiccAppOperationStatus Status { get; }

    UiccAppRecordKind Kind { get; }

    int RecordCount { get; }

    int RecordSize { get; }

    UiccAccessCondition ReadAccessCondition { get; }

    UiccAccessCondition WriteAccessCondition { get; }
  }
}
