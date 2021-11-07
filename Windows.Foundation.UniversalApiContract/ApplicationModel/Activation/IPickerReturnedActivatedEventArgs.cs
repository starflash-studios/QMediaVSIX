// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IPickerReturnedActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides data for the Activated event when it occurs after a picker returns.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(906883001, 43475, 18820, 164, 237, 158, 199, 52, 96, 73, 33)]
  public interface IPickerReturnedActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Gets an identifier indicating the type of picker operation that was performed prior to the activation.</summary>
    /// <returns>An identifier indicating the type of picker operation that was performed prior to the activation.</returns>
    string PickerOperationId { get; }
  }
}
