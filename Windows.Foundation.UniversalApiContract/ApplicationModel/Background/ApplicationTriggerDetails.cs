// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ApplicationTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>The details of an ApplicationTrigger.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ApplicationTriggerDetails : IApplicationTriggerDetails
  {
    /// <summary>The arguments that were passed to the background task using the ApplicationTrigger.RequestAsync(ValueSet) method.</summary>
    /// <returns>The serialized arguments.</returns>
    public extern ValueSet Arguments { [MethodImpl] get; }
  }
}
