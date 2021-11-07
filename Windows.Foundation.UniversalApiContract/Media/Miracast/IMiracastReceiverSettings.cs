// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.IMiracastReceiverSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  [ExclusiveTo(typeof (MiracastReceiverSettings))]
  [Guid(1473064740, 50522, 24510, 148, 100, 235, 5, 48, 119, 5, 221)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IMiracastReceiverSettings
  {
    string FriendlyName { get; set; }

    string ModelName { get; set; }

    string ModelNumber { get; set; }

    MiracastReceiverAuthorizationMethod AuthorizationMethod { get; set; }

    bool RequireAuthorizationFromKnownTransmitters { get; set; }
  }
}
