// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IKnownRemoteSystemCapabilitiesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2164843392, 32650, 17636, 146, 205, 3, 182, 70, 155, 148, 163)]
  [ExclusiveTo(typeof (KnownRemoteSystemCapabilities))]
  internal interface IKnownRemoteSystemCapabilitiesStatics
  {
    string AppService { get; }

    string LaunchUri { get; }

    string RemoteSession { get; }

    string SpatialEntity { get; }
  }
}
