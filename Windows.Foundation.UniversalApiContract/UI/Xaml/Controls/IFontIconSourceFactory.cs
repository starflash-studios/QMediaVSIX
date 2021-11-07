// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFontIconSourceFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (FontIconSource))]
  [Guid(2346514109, 64518, 17080, 179, 11, 117, 5, 8, 42, 195, 143)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  internal interface IFontIconSourceFactory
  {
    FontIconSource CreateInstance(object baseInterface, out object innerInterface);
  }
}
