// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.InertiaExpansionBehavior
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Controls the deceleration of a resizing manipulation during inertia.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class InertiaExpansionBehavior : IInertiaExpansionBehavior
  {
    /// <summary>Gets or sets the rate that resizing slows.</summary>
    /// <returns>The rate that resizing slows.</returns>
    public extern double DesiredDeceleration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the amount the element resizes at the end of inertia.</summary>
    /// <returns>The amount the element resizes at the end of inertia.</returns>
    public extern double DesiredExpansion { [MethodImpl] get; [MethodImpl] set; }
  }
}
