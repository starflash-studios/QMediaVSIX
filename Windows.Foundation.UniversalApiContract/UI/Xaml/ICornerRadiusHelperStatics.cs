// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ICornerRadiusHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(4104255065, 54484, 17695, 163, 135, 214, 191, 75, 36, 81, 212)]
  [ExclusiveTo(typeof (CornerRadiusHelper))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ICornerRadiusHelperStatics
  {
    CornerRadius FromRadii(
      double topLeft,
      double topRight,
      double bottomRight,
      double bottomLeft);

    CornerRadius FromUniformRadius(double uniformRadius);
  }
}
