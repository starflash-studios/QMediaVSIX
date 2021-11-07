// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IProtocolActivatedEventArgsWithCallerPackageFamilyNameAndData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides data and the package family name of the app that activated the current app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3628731410, 23695, 17292, 131, 203, 194, 143, 204, 11, 47, 219)]
  public interface IProtocolActivatedEventArgsWithCallerPackageFamilyNameAndData : 
    IActivatedEventArgs
  {
    /// <summary>Gets the package family name of the application that activated the current application.</summary>
    /// <returns>The package family name of the application that activated the current application.</returns>
    string CallerPackageFamilyName { get; }

    /// <summary>Data received from the application that activated the current application.</summary>
    /// <returns>User-defined data.</returns>
    ValueSet Data { get; }
  }
}
