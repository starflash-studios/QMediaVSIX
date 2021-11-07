// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRatingItemInfoFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (RatingItemInfo))]
  [Guid(2969387990, 53228, 17352, 154, 197, 11, 13, 94, 37, 216, 98)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IRatingItemInfoFactory
  {
    RatingItemInfo CreateInstance(object baseInterface, out object innerInterface);
  }
}
