﻿// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IDatagramSocketControl3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DatagramSocketControl))]
  [Guid(3572204118, 8045, 17816, 155, 87, 212, 42, 0, 29, 243, 73)]
  internal interface IDatagramSocketControl3
  {
    bool MulticastOnly { get; set; }
  }
}