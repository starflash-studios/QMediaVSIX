// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IFileSavePickerActivatedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information about the activated event that fires when the user saves a file through the file picker and selects the app as the location.</summary>
  [Guid(1802763795, 11506, 19784, 140, 188, 175, 103, 210, 63, 28, 231)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IFileSavePickerActivatedEventArgs2
  {
    /// <summary>The package family name of the app that launched your app.</summary>
    /// <returns>The caller's package family name.</returns>
    string CallerPackageFamilyName { get; }

    /// <summary>Gets the ID of the enterprise that owns the file.</summary>
    /// <returns>The ID of the enterprise that owns the file.</returns>
    string EnterpriseId { get; }
  }
}
