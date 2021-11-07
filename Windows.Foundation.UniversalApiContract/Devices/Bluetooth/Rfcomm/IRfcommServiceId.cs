// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommServiceId
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [Guid(576885252, 32258, 16407, 129, 54, 218, 27, 106, 27, 155, 191)]
  [ExclusiveTo(typeof (RfcommServiceId))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRfcommServiceId
  {
    Guid Uuid { get; }

    uint AsShortId();

    string AsString();
  }
}
