// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.RenderingDeviceReplacedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Arguments for the RenderingDeviceReplaced event.</summary>
  [WebHostHidden]
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RenderingDeviceReplacedEventArgs : 
    CompositionObject,
    IRenderingDeviceReplacedEventArgs
  {
    /// <summary>The new graphics device.</summary>
    /// <returns>The new graphics device.</returns>
    public extern CompositionGraphicsDevice GraphicsDevice { [MethodImpl] get; }
  }
}
