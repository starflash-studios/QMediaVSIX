// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IIconElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (IconElement))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2599452731, 53324, 18042, 187, 213, 155, 129, 240, 45, 154, 86)]
  [WebHostHidden]
  internal interface IIconElement
  {
    Brush Foreground { get; set; }
  }
}
