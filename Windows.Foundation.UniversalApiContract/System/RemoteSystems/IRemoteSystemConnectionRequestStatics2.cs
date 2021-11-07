// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemConnectionRequestStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Guid(1175392295, 25836, 22926, 168, 0, 79, 46, 229, 141, 239, 25)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (RemoteSystemConnectionRequest))]
  internal interface IRemoteSystemConnectionRequestStatics2
  {
    RemoteSystemConnectionRequest CreateFromConnectionToken(
      string connectionToken);

    RemoteSystemConnectionRequest CreateFromConnectionTokenForUser(
      User user,
      string connectionToken);
  }
}
