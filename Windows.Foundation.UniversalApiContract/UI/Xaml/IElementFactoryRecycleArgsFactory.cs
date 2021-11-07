// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IElementFactoryRecycleArgsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(2375181577, 59917, 21531, 130, 113, 249, 233, 17, 143, 94, 124)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (ElementFactoryRecycleArgs))]
  [WebHostHidden]
  internal interface IElementFactoryRecycleArgsFactory
  {
    ElementFactoryRecycleArgs CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
