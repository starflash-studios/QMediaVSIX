// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemKindStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemKinds))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4130436659, 43796, 16848, 149, 83, 121, 106, 173, 184, 130, 219)]
  internal interface IRemoteSystemKindStatics
  {
    string Phone { get; }

    string Hub { get; }

    string Holographic { get; }

    string Desktop { get; }

    string Xbox { get; }
  }
}
