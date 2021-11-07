// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IEffectiveViewportChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(1441672833, 7192, 23021, 189, 61, 196, 202, 143, 167, 209, 144)]
  [ExclusiveTo(typeof (EffectiveViewportChangedEventArgs))]
  internal interface IEffectiveViewportChangedEventArgs
  {
    Rect EffectiveViewport { get; }

    Rect MaxViewport { get; }

    double BringIntoViewDistanceX { get; }

    double BringIntoViewDistanceY { get; }
  }
}
