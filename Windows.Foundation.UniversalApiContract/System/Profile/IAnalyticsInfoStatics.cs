// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.IAnalyticsInfoStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AnalyticsInfo))]
  [Guid(492757094, 6285, 23465, 67, 135, 172, 174, 176, 231, 227, 5)]
  internal interface IAnalyticsInfoStatics
  {
    AnalyticsVersionInfo VersionInfo { get; }

    string DeviceForm { get; }
  }
}
