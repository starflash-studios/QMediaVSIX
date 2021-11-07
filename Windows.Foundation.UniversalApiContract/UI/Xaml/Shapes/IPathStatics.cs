// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IPathStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Path))]
  [Guid(4129809821, 34780, 16706, 129, 241, 151, 252, 127, 248, 100, 28)]
  [WebHostHidden]
  internal interface IPathStatics
  {
    DependencyProperty DataProperty { get; }
  }
}
