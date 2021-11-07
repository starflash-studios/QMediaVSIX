// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.QuarticEase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Represents an easing function that creates an animation that accelerates and/or decelerates using the formula *f* (*t*) = *t*&lt;sup&gt;4&lt;/sup&gt;.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class QuarticEase : EasingFunctionBase, IQuarticEase
  {
    /// <summary>Initializes a new instance of the QuarticEase class.</summary>
    [MethodImpl]
    public extern QuarticEase();
  }
}
