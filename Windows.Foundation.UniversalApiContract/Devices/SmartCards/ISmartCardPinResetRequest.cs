// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardPinResetRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [ExclusiveTo(typeof (SmartCardPinResetRequest))]
  [Guid(318651469, 24505, 20110, 159, 246, 97, 244, 117, 18, 79, 239)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmartCardPinResetRequest
  {
    IBuffer Challenge { get; }

    DateTime Deadline { get; }

    SmartCardPinResetDeferral GetDeferral();

    void SetResponse(IBuffer response);
  }
}
