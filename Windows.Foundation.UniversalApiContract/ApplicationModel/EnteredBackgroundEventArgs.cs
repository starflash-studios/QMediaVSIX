// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.EnteredBackgroundEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Gets the deferral object when an app has entered the background state.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EnteredBackgroundEventArgs : IEnteredBackgroundEventArgs
  {
    /// <summary>Gets the deferral object which delays the transition from running in the background state to the suspended state until the app calls Deferral.Complete or the deadline for navigation has passed.</summary>
    /// <returns>The deferral object you will use to indicate when your processing is complete.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
