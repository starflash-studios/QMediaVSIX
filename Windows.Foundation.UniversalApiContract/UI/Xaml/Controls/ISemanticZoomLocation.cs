// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISemanticZoomLocation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (SemanticZoomLocation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1107367734, 58306, 18795, 188, 78, 215, 80, 212, 55, 91, 154)]
  [WebHostHidden]
  internal interface ISemanticZoomLocation
  {
    object Item { get; set; }

    Rect Bounds { get; set; }
  }
}
