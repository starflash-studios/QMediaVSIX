// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IBrushOverrides2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [Guid(3499274577, 55355, 23169, 167, 30, 161, 199, 248, 173, 105, 99)]
  [ExclusiveTo(typeof (Brush))]
  internal interface IBrushOverrides2
  {
    void PopulatePropertyInfoOverride(
      string propertyName,
      AnimationPropertyInfo animationPropertyInfo);
  }
}
