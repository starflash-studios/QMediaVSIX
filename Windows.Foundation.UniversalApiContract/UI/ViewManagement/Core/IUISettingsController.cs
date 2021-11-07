// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.IUISettingsController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  [ExclusiveTo(typeof (UISettingsController))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(2024086212, 5568, 23067, 167, 91, 172, 191, 156, 184, 187, 158)]
  internal interface IUISettingsController
  {
    void SetAdvancedEffectsEnabled(bool value);

    void SetAnimationsEnabled(bool value);

    void SetAutoHideScrollBars(bool value);

    void SetMessageDuration(uint value);

    void SetTextScaleFactor(double value);
  }
}
