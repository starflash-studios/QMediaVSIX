// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.CreateDefaultValueCallback
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents the method that can be invoked as part of a PropertyMetadata constructor to defer definition of a dependency property default value.</summary>
  /// <returns>The desired default value.</returns>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3605836076, 5557, 20168, 185, 92, 205, 210, 8, 240, 129, 83)]
  public delegate object CreateDefaultValueCallback();
}
