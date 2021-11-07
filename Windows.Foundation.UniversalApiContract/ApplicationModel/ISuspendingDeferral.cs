// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ISuspendingDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Manages a delayed app suspending operation.</summary>
  [Guid(1494484233, 35785, 20148, 182, 54, 218, 189, 196, 244, 111, 102)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ISuspendingDeferral
  {
    /// <summary>Notifies the system that the app has saved its data and is ready to be suspended.</summary>
    void Complete();
  }
}
