// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IViewModePreferences
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Guid(2274348346, 2969, 17097, 132, 208, 211, 241, 212, 3, 85, 75)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ViewModePreferences))]
  internal interface IViewModePreferences
  {
    ViewSizePreference ViewSizePreference { get; set; }

    Size CustomSize { get; set; }
  }
}
