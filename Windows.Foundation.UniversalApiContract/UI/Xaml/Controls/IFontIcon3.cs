// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFontIcon3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (FontIcon))]
  [Guid(1633016089, 7276, 18768, 135, 148, 35, 30, 240, 145, 77, 148)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFontIcon3
  {
    bool MirroredWhenRightToLeft { get; set; }
  }
}
