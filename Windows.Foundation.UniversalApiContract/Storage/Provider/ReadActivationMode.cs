// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.ReadActivationMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  /// <summary>Indicates when Windows will request a file update if another app retrieves the file from its MostRecentlyUsedList or FutureAccessList.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ReadActivationMode
  {
    /// <summary>Windows will not trigger a file update request when another app retrieves the local file.</summary>
    NotNeeded,
    /// <summary>Windows will trigger a file update request just before it has been retrieved from the app's MostRecentlyUsedList or FutureAccessList.</summary>
    BeforeAccess,
  }
}
