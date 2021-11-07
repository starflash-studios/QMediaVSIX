// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPathIcon
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PathIcon))]
  [WebHostHidden]
  [Guid(558654171, 50022, 18958, 185, 173, 220, 241, 104, 215, 236, 12)]
  internal interface IPathIcon
  {
    Geometry Data { get; set; }
  }
}
