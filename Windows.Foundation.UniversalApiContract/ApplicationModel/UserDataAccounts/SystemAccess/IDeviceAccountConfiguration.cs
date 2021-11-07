// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.SystemAccess.IDeviceAccountConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.SystemAccess
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DeviceAccountConfiguration))]
  [Guid(2902533027, 64476, 19739, 190, 67, 90, 39, 234, 74, 27, 99)]
  internal interface IDeviceAccountConfiguration
  {
    string AccountName { get; set; }

    string DeviceAccountTypeId { get; set; }

    DeviceAccountServerType ServerType { get; set; }

    string EmailAddress { get; set; }

    string Domain { get; set; }

    bool EmailSyncEnabled { get; set; }

    bool ContactsSyncEnabled { get; set; }

    bool CalendarSyncEnabled { get; set; }

    string IncomingServerAddress { get; set; }

    int IncomingServerPort { get; set; }

    bool IncomingServerRequiresSsl { get; set; }

    string IncomingServerUsername { get; set; }

    string OutgoingServerAddress { get; set; }

    int OutgoingServerPort { get; set; }

    bool OutgoingServerRequiresSsl { get; set; }

    string OutgoingServerUsername { get; set; }
  }
}
