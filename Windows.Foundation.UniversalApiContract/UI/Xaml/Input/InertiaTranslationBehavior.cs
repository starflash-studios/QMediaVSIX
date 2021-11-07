// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.InertiaTranslationBehavior
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Controls deceleration on a translation manipulation during inertia.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class InertiaTranslationBehavior : IInertiaTranslationBehavior
  {
    /// <summary>Gets or sets the rate the linear movement slows in device-independent units (1/96th inch per unit) per squared millisecond.</summary>
    /// <returns>The rate the linear movement slows in device-independent units (1/96th inch per unit) per squared millisecond.</returns>
    public extern double DesiredDeceleration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the linear movement of the manipulation at the end of inertia.</summary>
    /// <returns>The linear movement of the manipulation at the end of inertia.</returns>
    public extern double DesiredDisplacement { [MethodImpl] get; [MethodImpl] set; }
  }
}
