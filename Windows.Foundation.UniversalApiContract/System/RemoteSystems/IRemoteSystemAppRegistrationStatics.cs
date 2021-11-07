// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemAppRegistrationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemAppRegistration))]
  [Guid(28940352, 53202, 17727, 174, 37, 194, 83, 159, 8, 106, 253)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IRemoteSystemAppRegistrationStatics
  {
    RemoteSystemAppRegistration GetDefault();

    RemoteSystemAppRegistration GetForUser(User user);
  }
}
