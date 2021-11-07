// Decompiled with JetBrains decompiler
// Type: Windows.Services.Cortana.ICortanaActionableInsightsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Services.Cortana
{
  [Guid(3051279378, 40239, 23733, 155, 5, 53, 106, 11, 131, 108, 16)]
  [ExclusiveTo(typeof (CortanaActionableInsights))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  internal interface ICortanaActionableInsightsStatics
  {
    [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    CortanaActionableInsights GetDefault();

    [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    CortanaActionableInsights GetForUser(User user);
  }
}
