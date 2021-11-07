// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardProvisioning
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [Guid(435088829, 8107, 18300, 183, 18, 26, 44, 90, 241, 253, 110)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmartCardProvisioning))]
  internal interface ISmartCardProvisioning
  {
    SmartCard SmartCard { get; }

    [RemoteAsync]
    IAsyncOperation<Guid> GetIdAsync();

    [RemoteAsync]
    IAsyncOperation<string> GetNameAsync();

    [RemoteAsync]
    IAsyncOperation<SmartCardChallengeContext> GetChallengeContextAsync();

    IAsyncOperation<bool> RequestPinChangeAsync();

    IAsyncOperation<bool> RequestPinResetAsync(SmartCardPinResetHandler handler);
  }
}
