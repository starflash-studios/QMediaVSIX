// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IThicknessHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ThicknessHelper))]
  [Guid(3231259260, 1804, 19878, 135, 132, 1, 202, 128, 14, 183, 58)]
  internal interface IThicknessHelperStatics
  {
    Thickness FromLengths(double left, double top, double right, double bottom);

    Thickness FromUniformLength(double uniformLength);
  }
}
