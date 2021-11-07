// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ContainerVisual
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>A node in the visual tree that can have children.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IContainerVisualFactory), CompositionType.Public, 131072, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772164)]
  public class ContainerVisual : Visual, IContainerVisual
  {
    /// <summary>The children of the ContainerVisual.</summary>
    /// <returns>The children of the ContainerVisual.</returns>
    public extern VisualCollection Children { [MethodImpl] get; }
  }
}
