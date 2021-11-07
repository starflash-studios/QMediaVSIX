// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IIconSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (IconSource))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2464976213, 17899, 18340, 134, 60, 145, 178, 36, 4, 79, 155)]
  internal interface IIconSource
  {
    Brush Foreground { get; set; }
  }
}
