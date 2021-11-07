// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapElement3DStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(1630011674, 17679, 17450, 185, 217, 170, 129, 92, 113, 144, 122)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapElement3D))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IMapElement3DStatics
  {
    DependencyProperty LocationProperty { get; }

    DependencyProperty HeadingProperty { get; }

    DependencyProperty PitchProperty { get; }

    DependencyProperty RollProperty { get; }

    DependencyProperty ScaleProperty { get; }
  }
}
