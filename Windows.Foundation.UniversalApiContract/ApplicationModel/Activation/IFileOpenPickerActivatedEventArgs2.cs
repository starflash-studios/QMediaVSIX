// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IFileOpenPickerActivatedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information about the activated event that fires when the user tries to pick files or folders that are provided by the app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1584602982, 36127, 17915, 175, 29, 115, 32, 92, 143, 199, 161)]
  public interface IFileOpenPickerActivatedEventArgs2
  {
    /// <summary>The package family name of the app that launched your app.</summary>
    /// <returns>The caller's package family name.</returns>
    string CallerPackageFamilyName { get; }
  }
}
