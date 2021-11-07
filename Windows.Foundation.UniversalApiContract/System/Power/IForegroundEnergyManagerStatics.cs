// Decompiled with JetBrains decompiler
// Type: Windows.System.Power.IForegroundEnergyManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Power
{
  [Guid(2683857010, 58999, 18452, 154, 32, 83, 55, 202, 115, 43, 152)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ForegroundEnergyManager))]
  [Deprecated("Foreground Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")]
  internal interface IForegroundEnergyManagerStatics
  {
    uint LowUsageLevel { [Deprecated("Foreground Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")] get; }

    uint NearMaxAcceptableUsageLevel { [Deprecated("Foreground Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")] get; }

    uint MaxAcceptableUsageLevel { [Deprecated("Foreground Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")] get; }

    uint ExcessiveUsageLevel { [Deprecated("Foreground Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")] get; }

    uint RecentEnergyUsage { [Deprecated("Foreground Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")] get; }

    uint RecentEnergyUsageLevel { [Deprecated("Foreground Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")] get; }

    event EventHandler<object> RecentEnergyUsageIncreased;

    event EventHandler<object> RecentEnergyUsageReturnedToLow;
  }
}
