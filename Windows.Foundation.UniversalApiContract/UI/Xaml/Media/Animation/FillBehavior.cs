// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.FillBehavior
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Specifies how a Timeline behaves when it is outside its active period but its parent is inside its active or hold period.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum FillBehavior
  {
    /// <summary>After it reaches the end of its active period, the timeline holds its progress until the end of its parent's active and hold periods.</summary>
    HoldEnd,
    /// <summary>The timeline stops if it is outside its active period while its parent is inside its active period.</summary>
    Stop,
  }
}
