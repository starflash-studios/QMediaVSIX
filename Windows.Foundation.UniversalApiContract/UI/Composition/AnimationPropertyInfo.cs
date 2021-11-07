// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.AnimationPropertyInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Represents information about a property that can be animated.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772166)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Threading(ThreadingModel.Both)]
  public sealed class AnimationPropertyInfo : 
    CompositionObject,
    IAnimationPropertyInfo,
    IAnimationPropertyInfo2
  {
    /// <summary>Gets or sets a value that specifies how an animated property can be accessed.</summary>
    /// <returns>A value of the enumeration that specifies how an animated property can be accessed.</returns>
    public extern AnimationPropertyAccessMode AccessMode { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern CompositionObject GetResolvedCompositionObject();

    [MethodImpl]
    public extern string GetResolvedCompositionObjectProperty();
  }
}
