// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDependencyObjectCollectionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (DependencyObjectCollection))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(85883391, 45992, 18926, 181, 175, 172, 143, 104, 182, 73, 228)]
  internal interface IDependencyObjectCollectionFactory
  {
    DependencyObjectCollection CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
