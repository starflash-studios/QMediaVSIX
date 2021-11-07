// Decompiled with JetBrains decompiler
// Type: Windows.Services.Cortana.ICortanaPermissionsManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Cortana
{
  [Deprecated("ICortanaPermissionsManagerStatics is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (CortanaPermissionsManager))]
  [Guid(1991370362, 45125, 17428, 157, 109, 42, 211, 165, 254, 58, 126)]
  internal interface ICortanaPermissionsManagerStatics
  {
    [Deprecated("ICortanaPermissionsManagerStatics is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    CortanaPermissionsManager GetDefault();
  }
}
