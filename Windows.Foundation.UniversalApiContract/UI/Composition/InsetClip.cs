// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.InsetClip
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Clips a portion of a visual. The visible portion of the visual is a rectangle defined as inset values from the edges of the visual. The portion of the visual outside the rectangle is clipped.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class InsetClip : CompositionClip, IInsetClip
  {
    /// <summary>The offset from the bottom of the visual. The portion of the visual below the BottomtInset will be clipped. Animatable.</summary>
    /// <returns>The offset from the bottom of the visual.</returns>
    public extern float BottomInset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The offset from the left of the visual. The portion of the visual to the left of the LeftInset will be clipped. Animatable.</summary>
    /// <returns>The offset from the left of the visual.</returns>
    public extern float LeftInset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The offset from the right of the visual. The portion of the visual to the right of the RightInset will be clipped. Animatable.</summary>
    /// <returns>The offset from the right of the visual.</returns>
    public extern float RightInset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The offset from the top of the visual. The portion of the visual above the TopInset will be clipped. Animatable.</summary>
    /// <returns>The offset from the top of the visual.</returns>
    public extern float TopInset { [MethodImpl] get; [MethodImpl] set; }
  }
}
