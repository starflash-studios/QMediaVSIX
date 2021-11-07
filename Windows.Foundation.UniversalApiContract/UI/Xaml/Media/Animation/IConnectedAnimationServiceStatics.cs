// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IConnectedAnimationServiceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (ConnectedAnimationService))]
  [WebHostHidden]
  [Guid(3339161253, 54920, 16616, 143, 144, 150, 166, 39, 146, 115, 210)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IConnectedAnimationServiceStatics
  {
    ConnectedAnimationService GetForCurrentView();
  }
}
