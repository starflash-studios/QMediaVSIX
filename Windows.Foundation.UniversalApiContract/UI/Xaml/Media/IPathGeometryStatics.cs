// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IPathGeometryStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (PathGeometry))]
  [Guid(3655699386, 11450, 18241, 143, 141, 49, 152, 207, 81, 134, 185)]
  internal interface IPathGeometryStatics
  {
    DependencyProperty FillRuleProperty { get; }

    DependencyProperty FiguresProperty { get; }
  }
}
