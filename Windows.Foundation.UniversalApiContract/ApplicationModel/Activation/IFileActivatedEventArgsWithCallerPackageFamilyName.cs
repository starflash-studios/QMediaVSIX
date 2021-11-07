// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IFileActivatedEventArgsWithCallerPackageFamilyName
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides data when an app is activated because it is the program associated with a file.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(761327723, 53855, 19749, 134, 83, 225, 197, 225, 16, 131, 9)]
  public interface IFileActivatedEventArgsWithCallerPackageFamilyName : IActivatedEventArgs
  {
    /// <summary>The package family name of the app that launched this app.</summary>
    /// <returns>The caller's package family name.</returns>
    string CallerPackageFamilyName { get; }
  }
}
