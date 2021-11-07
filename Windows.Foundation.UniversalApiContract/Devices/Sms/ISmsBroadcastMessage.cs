// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsBroadcastMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [Guid(1974385649, 58551, 18548, 160, 156, 41, 86, 229, 146, 249, 87)]
  [ExclusiveTo(typeof (SmsBroadcastMessage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmsBroadcastMessage : ISmsMessageBase
  {
    DateTime Timestamp { get; }

    string To { get; }

    string Body { get; }

    int Channel { get; }

    SmsGeographicalScope GeographicalScope { get; }

    int MessageCode { get; }

    int UpdateNumber { get; }

    SmsBroadcastType BroadcastType { get; }

    bool IsEmergencyAlert { get; }

    bool IsUserPopupRequested { get; }
  }
}
