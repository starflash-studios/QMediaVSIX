// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectionProfileFilter2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ConnectionProfileFilter))]
  [Guid(3439759073, 50172, 20397, 157, 220, 89, 63, 170, 75, 120, 133)]
  internal interface IConnectionProfileFilter2
  {
    IReference<bool> IsRoaming { set; get; }

    IReference<bool> IsOverDataLimit { set; get; }

    IReference<bool> IsBackgroundDataUsageRestricted { set; get; }

    IBuffer RawData { get; }
  }
}
