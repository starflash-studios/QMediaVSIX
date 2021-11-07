// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothUuidHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ExclusiveTo(typeof (BluetoothUuidHelper))]
  [Guid(400493784, 53108, 19233, 175, 230, 245, 122, 17, 188, 222, 160)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IBluetoothUuidHelperStatics
  {
    Guid FromShortId(uint shortId);

    IReference<uint> TryGetShortId(Guid uuid);
  }
}
