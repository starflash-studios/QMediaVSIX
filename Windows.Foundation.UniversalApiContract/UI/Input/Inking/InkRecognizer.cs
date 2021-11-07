// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkRecognizer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Manages all aspects of handwriting recognition.</summary>
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.None)]
  public sealed class InkRecognizer : IInkRecognizer
  {
    /// <summary>Gets the name of the InkRecognizer object.</summary>
    /// <returns>The name.</returns>
    public extern string Name { [MethodImpl] get; }
  }
}
