// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFontIconFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(477633387, 14271, 19932, 161, 168, 27, 119, 219, 60, 240, 234)]
  [ExclusiveTo(typeof (FontIcon))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFontIconFactory
  {
    FontIcon CreateInstance(object baseInterface, out object innerInterface);
  }
}
