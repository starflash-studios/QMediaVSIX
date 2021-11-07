// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.IAnalyticsVersionInfo2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [ExclusiveTo(typeof (AnalyticsVersionInfo))]
  [Guid(1994986929, 65334, 16508, 159, 87, 22, 13, 62, 84, 7, 71)]
  [ContractVersion(typeof (UniversalApiContract), 720896)]
  internal interface IAnalyticsVersionInfo2
  {
    string ProductName { get; }
  }
}
