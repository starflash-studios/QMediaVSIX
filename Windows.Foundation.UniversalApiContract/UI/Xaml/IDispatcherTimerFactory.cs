// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDispatcherTimerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (DispatcherTimer))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3918929518, 13862, 16442, 175, 224, 4, 13, 88, 22, 86, 50)]
  internal interface IDispatcherTimerFactory
  {
    DispatcherTimer CreateInstance(object baseInterface, out object innerInterface);
  }
}
