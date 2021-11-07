// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ApplicationInitializationCallbackParams
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>A class that developers should derive from in order to pass information for a custom initialization sequence, in cases where both an Application subclass is present and the entry point Start call is adjusted to pass the information.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class ApplicationInitializationCallbackParams : 
    IApplicationInitializationCallbackParams
  {
  }
}
