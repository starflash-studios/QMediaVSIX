// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemApp
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Guid(2162539709, 54605, 16817, 155, 22, 104, 16, 168, 113, 237, 79)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (RemoteSystemApp))]
  internal interface IRemoteSystemApp
  {
    string Id { get; }

    string DisplayName { get; }

    bool IsAvailableByProximity { get; }

    bool IsAvailableBySpatialProximity { get; }

    IMapView<string, string> Attributes { get; }
  }
}
