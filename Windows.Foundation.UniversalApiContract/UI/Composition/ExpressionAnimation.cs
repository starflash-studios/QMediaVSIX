// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ExpressionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>A Composition Animation that uses a mathematical equation to calculate the value for an animating property every frame.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class ExpressionAnimation : CompositionAnimation, IExpressionAnimation
  {
    /// <summary>The mathematical equation specifying how the animated value is calculated each frame. The Expression is the core of an ExpressionAnimation and represents the equation the system will use to calculate the value of the animation property each frame. The equation is set on this property in the form of a string.</summary>
    /// <returns>The mathematical equation specifying how the animated value is calculated each frame.</returns>
    public extern string Expression { [MethodImpl] get; [MethodImpl] set; }
  }
}
