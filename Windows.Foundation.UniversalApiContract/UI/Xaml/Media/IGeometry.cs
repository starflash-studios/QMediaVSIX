// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGeometry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Geometry))]
  [WebHostHidden]
  [Guid(4195498121, 2765, 16763, 182, 45, 92, 161, 191, 77, 252, 14)]
  internal interface IGeometry
  {
    Transform Transform { get; set; }

    Rect Bounds { get; }
  }
}
