// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.PickerClosingOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  /// <summary>Lets an app that provides files get the deadline for responding to a closing event and get a deferral so the app can respond to the event asynchronously.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PickerClosingOperation : IPickerClosingOperation
  {
    /// <summary>Gets a pickerClosingDeferral that the app providing files through the file picker can use to respond asynchronously to a closing event.</summary>
    /// <returns>The pickerClosingDeferral that the app providing files through the file picker can use to respond asynchronously to a closing event.</returns>
    [MethodImpl]
    public extern PickerClosingDeferral GetDeferral();

    /// <summary>Gets a dateTime object that indicates when the system will shut down the app that is providing files through the file picker without further notice.</summary>
    /// <returns>The dateTime object that indicates when the system will shut down the app.</returns>
    public extern DateTime Deadline { [MethodImpl] get; }
  }
}
