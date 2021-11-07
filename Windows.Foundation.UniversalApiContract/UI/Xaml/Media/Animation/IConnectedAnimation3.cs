// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IConnectedAnimation3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(1848656070, 1072, 22976, 168, 12, 204, 238, 210, 231, 120, 221)]
  [ExclusiveTo(typeof (ConnectedAnimation))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IConnectedAnimation3
  {
    ConnectedAnimationConfiguration Configuration { get; set; }
  }
}
