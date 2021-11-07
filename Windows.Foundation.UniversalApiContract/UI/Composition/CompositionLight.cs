// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionLight
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Base class for a light source that can target a UI scene.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Composable(typeof (ICompositionLightFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class CompositionLight : 
    CompositionObject,
    ICompositionLight,
    ICompositionLight2,
    ICompositionLight3
  {
    /// <summary>The collection of Visuals targeted by the light.</summary>
    /// <returns>The collection of Visuals targeted by the light.</returns>
    public extern VisualUnorderedCollection Targets { [MethodImpl] get; }

    /// <summary>Gets a collection of Visuals that are not targeted by the light.</summary>
    /// <returns>The collection of Visuals that are not targeted by the light.</returns>
    public extern VisualUnorderedCollection ExclusionsFromTargets { [MethodImpl] get; }

    /// <summary>Gets or sets a value that determines whether the composition light is on.</summary>
    /// <returns>**true** if the light is on; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }
  }
}
