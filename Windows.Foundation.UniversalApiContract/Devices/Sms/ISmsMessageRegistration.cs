﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsMessageRegistration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [Guid(387993662, 62287, 17515, 131, 179, 15, 241, 153, 35, 180, 9)]
  [ExclusiveTo(typeof (SmsMessageRegistration))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmsMessageRegistration
  {
    string Id { get; }

    void Unregister();

    event TypedEventHandler<SmsMessageRegistration, SmsMessageReceivedTriggerDetails> MessageReceived;
  }
}