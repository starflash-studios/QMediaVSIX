// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkDrawingAttributesPencilProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Provides a set of static InkDrawingAttributes properties for rendering a pencil stroke on an InkCanvas.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class InkDrawingAttributesPencilProperties : IInkDrawingAttributesPencilProperties
  {
    /// <summary>Gets or sets the level of transparency used for rendering a pencil stroke on an InkCanvas.</summary>
    /// <returns>A value between 0.01 and 5.0 that specifies the opacity factor, with 5.0 indicating full opacity. The default value is 1.0.</returns>
    public extern double Opacity { [MethodImpl] get; [MethodImpl] set; }
  }
}
