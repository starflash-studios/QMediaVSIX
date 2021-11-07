// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionControllerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (RemoteSystemSessionController))]
  [Guid(3217829739, 44093, 16793, 130, 205, 102, 112, 167, 115, 239, 46)]
  internal interface IRemoteSystemSessionControllerFactory
  {
    [Overload("CreateController")]
    RemoteSystemSessionController CreateController(string displayName);

    [Overload("CreateControllerWithSessionOptions")]
    RemoteSystemSessionController CreateController(
      string displayName,
      RemoteSystemSessionOptions options);
  }
}
