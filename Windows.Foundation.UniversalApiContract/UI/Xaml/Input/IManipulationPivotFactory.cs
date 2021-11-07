// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IManipulationPivotFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [Guid(1829089337, 14082, 17302, 173, 155, 168, 37, 239, 166, 58, 59)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ManipulationPivot))]
  [WebHostHidden]
  internal interface IManipulationPivotFactory
  {
    ManipulationPivot CreateInstanceWithCenterAndRadius(
      Point center,
      double radius);
  }
}
