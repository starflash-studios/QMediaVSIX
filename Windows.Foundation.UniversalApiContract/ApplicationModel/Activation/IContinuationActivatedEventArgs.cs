// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IContinuationActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides data when an app is activated after an operation that suspends the app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3850438325, 5471, 19092, 167, 66, 199, 224, 143, 78, 24, 140)]
  public interface IContinuationActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Gets a set of values populated by the app before an operation that deactivates the app in order to provide context when the app is activated.</summary>
    /// <returns>A set of values populated by the app before an operation that deactivates the app.</returns>
    ValueSet ContinuationData { get; }
  }
}
