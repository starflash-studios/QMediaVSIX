// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRatingItemImageInfoFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(647889906, 55929, 18311, 159, 74, 36, 166, 250, 86, 205, 226)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (RatingItemImageInfo))]
  [WebHostHidden]
  internal interface IRatingItemImageInfoFactory
  {
    RatingItemImageInfo CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
