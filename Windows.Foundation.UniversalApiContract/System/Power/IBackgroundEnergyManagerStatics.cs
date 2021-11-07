// Decompiled with JetBrains decompiler
// Type: Windows.System.Power.IBackgroundEnergyManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Power
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BackgroundEnergyManager))]
  [Deprecated("Background Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")]
  [Guid(3004571029, 4480, 17270, 150, 225, 64, 149, 86, 129, 71, 206)]
  internal interface IBackgroundEnergyManagerStatics
  {
    uint LowUsageLevel { [Deprecated("Background Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")] get; }

    uint NearMaxAcceptableUsageLevel { [Deprecated("Background Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")] get; }

    uint MaxAcceptableUsageLevel { [Deprecated("Background Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")] get; }

    uint ExcessiveUsageLevel { [Deprecated("Background Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")] get; }

    uint NearTerminationUsageLevel { [Deprecated("Background Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")] get; }

    uint TerminationUsageLevel { [Deprecated("Background Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")] get; }

    uint RecentEnergyUsage { [Deprecated("Background Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")] get; }

    uint RecentEnergyUsageLevel { [Deprecated("Background Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")] get; }

    event EventHandler<object> RecentEnergyUsageIncreased;

    event EventHandler<object> RecentEnergyUsageReturnedToLow;
  }
}
