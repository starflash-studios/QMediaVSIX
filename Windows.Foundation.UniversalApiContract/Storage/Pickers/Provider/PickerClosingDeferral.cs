// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.PickerClosingDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  /// <summary>Use by an app that provides files to indicate asynchronously that the app is finished responding to a closing event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PickerClosingDeferral : IPickerClosingDeferral
  {
    /// <summary>Signals that the app providing files has finished responding to a closing event.</summary>
    [MethodImpl]
    public extern void Complete();
  }
}
