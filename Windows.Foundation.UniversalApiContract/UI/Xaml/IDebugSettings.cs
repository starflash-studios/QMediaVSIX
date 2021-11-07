// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDebugSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (DebugSettings))]
  [Guid(1027940248, 50855, 19735, 131, 152, 216, 58, 6, 113, 131, 216)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IDebugSettings
  {
    bool EnableFrameRateCounter { get; set; }

    bool IsBindingTracingEnabled { get; set; }

    bool IsOverdrawHeatMapEnabled { get; set; }

    event BindingFailedEventHandler BindingFailed;
  }
}
