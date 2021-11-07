// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardPinResetDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [Guid(415845036, 30725, 16388, 133, 228, 187, 239, 172, 143, 104, 132)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmartCardPinResetDeferral))]
  internal interface ISmartCardPinResetDeferral
  {
    void Complete();
  }
}
