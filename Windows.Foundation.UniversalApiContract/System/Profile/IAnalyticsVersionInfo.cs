// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.IAnalyticsVersionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AnalyticsVersionInfo))]
  [Guid(2455843000, 39253, 19572, 189, 193, 124, 208, 222, 207, 155, 3)]
  internal interface IAnalyticsVersionInfo
  {
    string DeviceFamily { get; }

    string DeviceFamilyVersion { get; }
  }
}
