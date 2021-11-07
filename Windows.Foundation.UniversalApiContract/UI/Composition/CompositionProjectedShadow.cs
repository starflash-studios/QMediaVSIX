// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionProjectedShadow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Represents a scene-based shadow calculated using the relationship between the light, the visual that casts the shadow,and the visual that receives the shadow, such that the shadow is drawn differently on each receiver.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class CompositionProjectedShadow : CompositionObject, ICompositionProjectedShadow
  {
    /// <summary>Gets or sets the multiplier for the shadow's blur radius.</summary>
    /// <returns>The multiplier for the shadow's blur radius.</returns>
    public extern float BlurRadiusMultiplier { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of objects that cast a shadow on the receivers.</summary>
    /// <returns>The collection of objects that cast a shadow on the receivers.</returns>
    public extern CompositionProjectedShadowCasterCollection Casters { [MethodImpl] get; }

    /// <summary>Gets or sets the composition light that determines the direction the shadow is cast.</summary>
    /// <returns>The composition light that determines the direction the shadow is cast.</returns>
    public extern CompositionLight LightSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum blur radius of the shadow.</summary>
    /// <returns>The maximum blur radius of the shadow.</returns>
    public extern float MaxBlurRadius { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum blur radius of the shadow.</summary>
    /// <returns>The minimum blur radius of the shadow.</returns>
    public extern float MinBlurRadius { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of objects that the shadow is cast on.</summary>
    /// <returns>The collection of objects that the shadow is cast on.</returns>
    public extern CompositionProjectedShadowReceiverUnorderedCollection Receivers { [MethodImpl] get; }
  }
}
