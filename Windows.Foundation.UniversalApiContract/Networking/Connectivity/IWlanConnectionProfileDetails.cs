// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IWlanConnectionProfileDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1444976843, 45914, 19441, 168, 132, 183, 85, 126, 136, 255, 134)]
  [ExclusiveTo(typeof (WlanConnectionProfileDetails))]
  internal interface IWlanConnectionProfileDetails
  {
    string GetConnectedSsid();
  }
}
