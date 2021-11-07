// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.IPeerInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  [ExclusiveTo(typeof (PeerInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(537022216, 40959, 17908, 182, 233, 64, 139, 46, 190, 243, 115)]
  internal interface IPeerInformation
  {
    string DisplayName { get; }
  }
}
