// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Guid(3981981901, 7696, 19084, 180, 166, 78, 95, 214, 249, 119, 33)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (RemoteSystem))]
  internal interface IRemoteSystem
  {
    string DisplayName { get; }

    string Id { get; }

    string Kind { get; }

    RemoteSystemStatus Status { get; }

    bool IsAvailableByProximity { get; }
  }
}
