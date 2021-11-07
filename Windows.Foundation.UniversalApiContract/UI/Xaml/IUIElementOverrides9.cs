// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElementOverrides9
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (UIElement))]
  [WebHostHidden]
  [Guid(2590923123, 28003, 21746, 144, 250, 98, 129, 59, 32, 183, 185)]
  internal interface IUIElementOverrides9
  {
    void PopulatePropertyInfoOverride(
      string propertyName,
      AnimationPropertyInfo animationPropertyInfo);
  }
}
