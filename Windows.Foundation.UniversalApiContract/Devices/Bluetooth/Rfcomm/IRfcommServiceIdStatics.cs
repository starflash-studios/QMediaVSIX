// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommServiceIdStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [ExclusiveTo(typeof (RfcommServiceId))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(706191034, 43381, 18147, 181, 107, 8, 255, 215, 131, 165, 254)]
  internal interface IRfcommServiceIdStatics
  {
    RfcommServiceId FromUuid(Guid uuid);

    RfcommServiceId FromShortId(uint shortId);

    RfcommServiceId SerialPort { get; }

    RfcommServiceId ObexObjectPush { get; }

    RfcommServiceId ObexFileTransfer { get; }

    RfcommServiceId PhoneBookAccessPce { get; }

    RfcommServiceId PhoneBookAccessPse { get; }

    RfcommServiceId GenericFileTransfer { get; }
  }
}
