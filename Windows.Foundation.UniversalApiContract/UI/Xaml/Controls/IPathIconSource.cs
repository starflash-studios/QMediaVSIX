// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPathIconSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (PathIconSource))]
  [WebHostHidden]
  [Guid(524747022, 45829, 18531, 139, 122, 21, 208, 141, 99, 60, 122)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IPathIconSource
  {
    Geometry Data { get; set; }
  }
}
