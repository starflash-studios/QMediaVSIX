// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ILineGeometry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [Guid(820892834, 36805, 16559, 167, 162, 194, 127, 231, 170, 19, 99)]
  [ExclusiveTo(typeof (LineGeometry))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILineGeometry
  {
    Point StartPoint { get; set; }

    Point EndPoint { get; set; }
  }
}
