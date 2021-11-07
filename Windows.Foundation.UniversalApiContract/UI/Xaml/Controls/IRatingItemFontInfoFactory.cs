// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRatingItemFontInfoFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (RatingItemFontInfo))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2516844118, 40607, 16565, 186, 225, 68, 129, 187, 115, 188, 211)]
  [WebHostHidden]
  internal interface IRatingItemFontInfoFactory
  {
    RatingItemFontInfo CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
