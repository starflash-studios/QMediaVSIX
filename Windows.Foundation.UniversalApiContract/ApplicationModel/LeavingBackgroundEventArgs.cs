// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LeavingBackgroundEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Gets the deferral object when the app is leaving the background state.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class LeavingBackgroundEventArgs : ILeavingBackgroundEventArgs
  {
    /// <summary>Gets the deferral object which delays the transition from running in the background to running in the foreground until the app calls Deferral.Complete or the deadline for navigation has passed.</summary>
    /// <returns>The deferral object you will use to indicate that your processing is done.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
