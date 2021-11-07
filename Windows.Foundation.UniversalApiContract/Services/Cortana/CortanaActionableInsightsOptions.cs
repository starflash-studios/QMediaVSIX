// Decompiled with JetBrains decompiler
// Type: Windows.Services.Cortana.CortanaActionableInsightsOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Cortana
{
  /// <summary>Specifies options for refining the insights retrieved through the CortanaActionableInsights methods.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Deprecated("CortanaActionableInsightsOptions is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  public sealed class CortanaActionableInsightsOptions : ICortanaActionableInsightsOptions
  {
    /// <summary>Creates a CortanaActionableInsightsOptions object.</summary>
    [MethodImpl]
    public extern CortanaActionableInsightsOptions();

    /// <summary>A URI that identifies where the specified text or image content originated.</summary>
    /// <returns>The web link address. This value can be null.</returns>
    public extern Uri ContentSourceWebLink { [Deprecated("CortanaActionableInsightsOptions is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("CortanaActionableInsightsOptions is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Text from the surrounding context of the content supplied to CortanaActionableInsights for showing insights.</summary>
    /// <returns>The textual context surrounding the content (maximum length of 3000 characters). This value can be null.</returns>
    public extern string SurroundingText { [Deprecated("CortanaActionableInsightsOptions is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("CortanaActionableInsightsOptions is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }
  }
}
