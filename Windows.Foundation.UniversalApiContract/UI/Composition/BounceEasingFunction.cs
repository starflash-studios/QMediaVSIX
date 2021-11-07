// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.BounceEasingFunction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class BounceEasingFunction : CompositionEasingFunction, IBounceEasingFunction
  {
    public extern CompositionEasingFunctionMode Mode { [MethodImpl] get; }

    public extern int Bounces { [MethodImpl] get; }

    public extern float Bounciness { [MethodImpl] get; }
  }
}
