// Decompiled with JetBrains decompiler
// Type: Windows.Services.Cortana.ICortanaActionableInsightsOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Cortana
{
  [ExclusiveTo(typeof (CortanaActionableInsightsOptions))]
  [Deprecated("CortanaActionableInsightsOptions is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2864888783, 38786, 21536, 184, 30, 122, 229, 106, 243, 24, 21)]
  internal interface ICortanaActionableInsightsOptions
  {
    Uri ContentSourceWebLink { [Deprecated("CortanaActionableInsightsOptions is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("CortanaActionableInsightsOptions is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] set; }

    string SurroundingText { [Deprecated("CortanaActionableInsightsOptions is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("CortanaActionableInsightsOptions is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] set; }
  }
}
