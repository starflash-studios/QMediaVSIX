// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IRectangleGeometry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (RectangleGeometry))]
  [WebHostHidden]
  [Guid(2723815256, 50549, 16790, 145, 207, 159, 223, 177, 4, 69, 195)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRectangleGeometry
  {
    Rect Rect { get; set; }
  }
}
