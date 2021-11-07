// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElementWeakCollectionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(1461986657, 6282, 21252, 135, 146, 164, 63, 53, 217, 15, 153)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [ExclusiveTo(typeof (UIElementWeakCollection))]
  internal interface IUIElementWeakCollectionFactory
  {
    UIElementWeakCollection CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
