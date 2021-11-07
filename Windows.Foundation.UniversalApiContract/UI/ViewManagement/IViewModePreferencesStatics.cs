// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IViewModePreferencesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Guid(1773537893, 24037, 16600, 131, 6, 56, 51, 223, 122, 34, 116)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ViewModePreferences))]
  internal interface IViewModePreferencesStatics
  {
    ViewModePreferences CreateDefault(ApplicationViewMode mode);
  }
}
