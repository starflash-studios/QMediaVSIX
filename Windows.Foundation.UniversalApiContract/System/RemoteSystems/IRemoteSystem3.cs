// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystem3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1924445333, 47046, 16574, 131, 27, 115, 86, 47, 18, 255, 168)]
  [ExclusiveTo(typeof (RemoteSystem))]
  internal interface IRemoteSystem3
  {
    string ManufacturerDisplayName { get; }

    string ModelDisplayName { get; }
  }
}
