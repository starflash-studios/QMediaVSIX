// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreIndependentInputSourceController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(157492764, 34046, 22410, 131, 202, 100, 37, 48, 156, 205, 228)]
  [ExclusiveTo(typeof (CoreIndependentInputSourceController))]
  internal interface ICoreIndependentInputSourceController
  {
    bool IsTransparentForUncontrolledInput { get; set; }

    bool IsPalmRejectionEnabled { get; set; }

    CoreIndependentInputSource Source { get; }

    [Overload("SetControlledInput")]
    void SetControlledInput(CoreInputDeviceTypes inputTypes);

    [Overload("SetControlledInputWithFilters")]
    void SetControlledInput(
      CoreInputDeviceTypes inputTypes,
      CoreIndependentInputFilters required,
      CoreIndependentInputFilters excluded);
  }
}
