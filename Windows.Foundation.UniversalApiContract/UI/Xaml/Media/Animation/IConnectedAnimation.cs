// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IConnectedAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (ConnectedAnimation))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(890790540, 62343, 19493, 172, 152, 68, 232, 108, 60, 173, 240)]
  internal interface IConnectedAnimation
  {
    event TypedEventHandler<ConnectedAnimation, object> Completed;

    [Overload("TryStart")]
    bool TryStart(UIElement destination);

    void Cancel();
  }
}
