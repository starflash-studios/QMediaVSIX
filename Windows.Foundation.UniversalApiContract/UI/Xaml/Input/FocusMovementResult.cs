// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.FocusMovementResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Represents the status of a focus operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  public sealed class FocusMovementResult : IFocusMovementResult
  {
    /// <summary>Gets a boolean value that indicates whether focus can be assigned to an object.</summary>
    /// <returns>True, if focus can be assigned; otherwise, false.</returns>
    public extern bool Succeeded { [MethodImpl] get; }
  }
}
