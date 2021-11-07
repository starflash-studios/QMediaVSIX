// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDirectConnectedAnimationConfigurationFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(93479913, 53939, 23159, 156, 244, 226, 109, 139, 84, 38, 8)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (DirectConnectedAnimationConfiguration))]
  [WebHostHidden]
  internal interface IDirectConnectedAnimationConfigurationFactory
  {
    DirectConnectedAnimationConfiguration CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
